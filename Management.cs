using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using RNC.Entities;
using RNC.Implementors;
using RNC.Tools;

namespace RNC
{
    public partial class Management : Form
    {
        private MainForm parentForm;
        private MeetingImpl meetingImpl;
        private MemberImpl memberImpl;
        private AttendanceImpl attendanceImpl;
        private List<Meeting> allAvailableMeetings;
        private List<Member> allAvailableMembers;
        private ConnectionManager connectionManager;
        private bool allCheckBoxCheckedByUser = true;

        public Management(MainForm mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            meetingImpl = new MeetingImpl();
            memberImpl = new MemberImpl();
            attendanceImpl = new AttendanceImpl();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            this.MeetingsListPopulator(meetingImpl.getAllMeetings());
            this.AttendeesListPopulator(memberImpl.getAllMembers());
            this.emailFormValid();

            //Formating of datetimepickers in the form
            this.dateMeetingDate.Format = DateTimePickerFormat.Custom;
            this.dateMeetingDate.CustomFormat = "ddd dd MMM yyyy";

            if (this.lstMeetings.Items.Count != 0)
            {
                this.lstMeetings.Items[0].Selected = true;
                this.CheckMeetingAttendance(this.allAvailableMeetings[this.lstMeetings.SelectedIndices[0]]);
            }

            //Statistics tab init

        }

        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            if (this.lstMeetings.Items.Count == 0 || (this.lstMeetings.Items.Count > 0 && this.lstMeetings.Items[0].BackColor != Color.OrangeRed))
            {
                this.lstMeetings.Items.Insert(0, DateTime.Today.ToShortDateString()).BackColor = Color.OrangeRed;
                this.lstMeetings.Items[0].Selected = true;
            }
        }

        private void btnSaveMeeting_Click(object sender, EventArgs e)
        {
            if (this.lstMeetings.SelectedIndices.Count != 0)
            {
                Meeting meeting;
                //Checks whether the selected meeting is fresh new or updatable.==>This is updatable
                if (this.lstMeetings.Items[this.lstMeetings.SelectedIndices[0]].BackColor != Color.OrangeRed)
                {
                    meeting = allAvailableMeetings[this.lstMeetings.SelectedIndices[0]];
                    meeting.Date = this.dateMeetingDate.Value;
                    meeting.Venue = this.txtAddress.Text;
                    if (this.meetingImpl.updateMeeting(meeting) != null)
                    {
                        List<Attendance> oldAttendances = this.attendanceImpl.getAttendanceByMeetingId(meeting.Id);
                        if (oldAttendances.Count > 0)
                        {
                            foreach (Attendance att in oldAttendances)
                            {
                                this.attendanceImpl.deleteAttendance(att);
                            }
                        }
                        if (this.clbxAttendees.CheckedItems.Count > 0)
                        {
                            for (int i = 0; i < this.clbxAttendees.CheckedItems.Count; i++)
                            {
                                Member member = allAvailableMembers[this.clbxAttendees.CheckedIndices[i]];
                                Attendance attendance = attendanceImpl.createAttendance(new Attendance(member, meeting));
                            }
                        }
                        this.lblStatus.ForeColor = Color.PaleGreen;
                        this.lblStatus.Text = "Mise à jour réussie...";
                    }
                    else
                    {
                        this.lblStatus.ForeColor = Color.OrangeRed;
                        this.lblStatus.Text = "Mise à jour échouée...";
                    }
                }
                //==>This is brand new!
                else
                {
                    meeting = new Meeting();
                    meeting.Date = this.dateMeetingDate.Value.Date;
                    meeting.Venue = this.txtAddress.Text;
                    Meeting createdMeeting = this.meetingImpl.createMeeting(meeting);
                    if (createdMeeting != null)
                    {
                        if (this.clbxAttendees.CheckedItems.Count > 0)
                        {
                            for (int i = 0; i < this.clbxAttendees.CheckedItems.Count; i++)
                            {
                                Member member = allAvailableMembers[this.clbxAttendees.CheckedIndices[i]];
                                Attendance attendance = attendanceImpl.createAttendance(new Attendance(member, createdMeeting));
                            }
                        }

                        this.lstMeetings.Items[0].BackColor = Color.Empty;
                        this.lblStatus.ForeColor = Color.PaleGreen;
                        this.lblStatus.Text = "Réunion créée...";
                    }
                    else
                    {
                        this.lblStatus.ForeColor = Color.OrangeRed;
                        this.lblStatus.Text = "Création de la réunion échouée...";
                    }
                }
                //To refresh the form
                this.MeetingsListPopulator(meetingImpl.getAllMeetings());
                this.AttendeesListPopulator(memberImpl.getAllMembers());
                this.CheckMeetingAttendance(meeting);
            }
            else
            {
                this.lblStatus.ForeColor = Color.OrangeRed;
                this.lblStatus.Text = "No selection made...";
            }
        }

        private void meetingsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMeetings.SelectedItems.Count != 0)
            {
                this.dateMeetingDate.Enabled = true;
                this.txtAddress.Enabled = true;
                this.clbxAttendees.Enabled = true;
                if (this.lstMeetings.Items[0].BackColor != Color.OrangeRed)
                {
                    Meeting meeting = allAvailableMeetings[this.lstMeetings.SelectedIndices[0]];
                    this.CheckMeetingAttendance(meeting);
                }
                else
                {
                    if (this.lstMeetings.Items[0].Selected == false)
                    {
                        Meeting meeting = allAvailableMeetings[this.lstMeetings.SelectedIndices[0] - 1];
                        this.CheckMeetingAttendance(meeting);
                    }
                    else
                    {
                        this.dateMeetingDate.Value = DateTime.Today;
                        this.txtAddress.Text = "";
                        this.CheckMeetingAttendance(null);
                    }
                }
            }

            else if (this.lstMeetings.SelectedItems.Count == 0)
            {
                this.dateMeetingDate.Enabled = false;
                this.txtAddress.Enabled = false;
                this.clbxAttendees.Enabled = false;
            }
        }

        private void statusTextChanged(object sender, EventArgs e)
        {
            if (this.lblStatus.Text.Length > 0 || this.lblEmailOptionsSavedStatus.Text.Length > 0)
            {
                this.timerStatus.Start();
            }
        }

        private void timerDoneTick(object sender, EventArgs e)
        {
            this.lblStatus.Text = "";
            this.lblEmailOptionsSavedStatus.Text = "";
        }

        private void btnDeleteMeeting_Click(object sender, EventArgs e)
        {
            if (this.lstMeetings.SelectedIndices.Count > 0)
            {
                ConfirmationBox conf = new ConfirmationBox();
                conf.ShowDialog();
                if (conf.Delete)
                {
                    if (this.meetingImpl.deleteMeeting(this.allAvailableMeetings[this.lstMeetings.SelectedIndices[0]]))
                    {
                        this.MeetingsListPopulator(this.meetingImpl.getAllMeetings());
                        this.lblStatus.Text = "Meeting deleted successfully";
                        if (this.lstMeetings.Items.Count > 0)
                        {
                            this.lstMeetings.Items[0].Selected = true;
                        }
                    }
                }
            }
        }

        private void selectedMeetingDateValueChanged(object sender, EventArgs e)
        {
            this.lstMeetings.Items[this.lstMeetings.SelectedIndices[0]].Text = this.dateMeetingDate.Value.ToString("dd MMM yyyy");
            this.lblMeetingDate.Text = this.dateMeetingDate.Value.ToLongDateString();
        }

        private void emailFormValid()
        {
            if (this.cbxEmailType.SelectedItem == null || this.txtSenderEmail.Text.Length == 0 || this.txtSenderPassword.Text.Length == 0 || this.txtSenderNames.Text.Length == 0 || !this.validEmail(this.txtSenderEmail.Text))
            {
                this.btnSaveOptions.Enabled = false;
            }
            else
            {
                this.btnSaveOptions.Enabled = true;
            }
        }

        private bool validEmail(string email)
        {
            if ((email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com") || email.EndsWith("@yahoo.fr") || email.EndsWith("@yahoo.be")) && email.IndexOf("@") > 1)
            {
                return true;
            }
            return false;
        }

        private void cbxEmailTypeIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxEmailType.SelectedIndex == 0)
            {
                try
                {
                    this.txtSenderEmail.Text = this.txtSenderEmail.Text.Substring(0, this.txtSenderEmail.Text.IndexOf("@")) + "@gmail.com";
                }
                catch (ArgumentOutOfRangeException)
                {
                    this.txtSenderEmail.Text += "@gmail.com";
                }
            }
            else if (this.cbxEmailType.SelectedIndex == 1)
            {
                try
                {
                    this.txtSenderEmail.Text = this.txtSenderEmail.Text.Substring(0, this.txtSenderEmail.Text.IndexOf("@")) + "@yahoo.fr";
                }
                catch (ArgumentOutOfRangeException)
                {
                    this.txtSenderEmail.Text += "@yahoo.fr";
                }
            }
            this.emailFormValid();
        }

        private void txtSenderEmailFocusLost(object sender, EventArgs e)
        {
            if (!validEmail(this.txtSenderEmail.Text))
            {
                this.lblEmailOptionsStatus.ForeColor = Color.OrangeRed;
                this.lblEmailOptionsStatus.Text = "Adresse email semble être mal saisi...";
                this.btnSaveOptions.Enabled = false;
            }
            else
            {
                this.lblEmailOptionsStatus.Text = "";
            }
            this.emailFormValid();
        }

        private void optionsTextChanged(object sender, EventArgs e)
        {
            this.emailFormValid();
        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            //ConnectionManager connectionManager = new ConnectionManager();
            XmlNode xmlNode = connectionManager.getSmtpSettingsXMLRoot();
            if (xmlNode != null)
            {
                foreach (XmlNode node in xmlNode.ChildNodes)
                {
                    {
                        if (this.cbxEmailType.SelectedIndex == 0)
                        {
                            if (node.Name == "Host")
                            {
                                node.Attributes[0].Value = "smtp.gmail.com";
                                node.Attributes[1].Value = "true";
                                node.Attributes[2].Value = "false";
                                node.Attributes[3].Value = "587";
                                foreach (XmlNode childNode in node.ChildNodes)
                                {
                                    if (childNode.Name == "SenderName")
                                    {
                                        childNode.InnerText = this.txtSenderNames.Text;
                                    }
                                    else if (childNode.Name == "Email")
                                    {
                                        childNode.InnerText = this.txtSenderEmail.Text;
                                    }
                                    else if (childNode.Name == "Password")
                                    {
                                        childNode.InnerText = this.txtSenderPassword.Text;
                                    }
                                }
                            }
                        }
                        else if (cbxEmailType.SelectedIndex == 1)
                        {
                            if (node.Name == "Host")
                            {
                                node.Attributes[0].Value = "smtp.mail.yahoo.com";
                                node.Attributes[1].Value = "false";
                                node.Attributes[2].Value = "n/a";
                                node.Attributes[3].Value = "465";
                                foreach (XmlNode childNode in node.ChildNodes)
                                {
                                    if (childNode.Name == "SenderName")
                                    {
                                        childNode.InnerText = this.txtSenderNames.Text;
                                    }
                                    else if (childNode.Name == "Email")
                                    {
                                        childNode.InnerText = this.txtSenderEmail.Text;
                                    }
                                    else if (childNode.Name == "Password")
                                    {
                                        childNode.InnerText = this.txtSenderPassword.Text;
                                    }
                                }
                            }
                        }
                        connectionManager.saveXmlDoc();
                        this.lblEmailOptionsSavedStatus.ForeColor = Color.PaleGreen;
                        this.lblEmailOptionsSavedStatus.Text = "Paramètres sauvegardés...";
                        //this.tabManager.SelectedTab = this.tabPageMeetings;
                    }
                }
            }
            else
            {
                this.lblEmailOptionsSavedStatus.ForeColor = Color.Red;
                this.lblEmailOptionsSavedStatus.Text = "Il y a eu un problème...";
            }
        }

        private void btnCancelOptions_Click(object sender, EventArgs e)
        {
            this.tabManager.SelectedTab = this.tabPageMeetings;
        }

        private void txtSearchToCheckTextChanged(object sender, EventArgs e)
        {
            if (this.txtSearchToCheck.Text.Length > 0)
            {
                List<Member> searchResult = memberImpl.getMembersByFirstOrLastName_Like(this.txtSearchToCheck.Text);
                if (searchResult.Count > 0)
                {
                    this.txtSearchToCheck.BackColor = Color.PaleGreen;
                    this.AttendeesListPopulator(searchResult);
                }
                else
                {
                    this.txtSearchToCheck.BackColor = Color.OrangeRed;
                    this.AttendeesListPopulator(null);
                }
            }
            else
            {
                this.txtSearchToCheck.BackColor = Color.Empty;
                this.AttendeesListPopulator(memberImpl.getAllMembers());
            }
        }

        //this populates the attendees' list
        private void AttendeesListPopulator(List<Member> members)
        {
            this.clbxAttendees.Items.Clear();
            if (members != null && members.Count != 0)
            {
                this.allAvailableMembers = members;
                foreach (Member member in members)
                {
                    this.clbxAttendees.Items.Add(member.Lastname + " " + member.Firstname);
                }
            }
        }

        private void AttendeesListFocusLost(object sender, EventArgs e)
        {
            this.txtSearchToCheck.Text = "";
        }

        private void CheckMeetingAttendance(Meeting meeting)
        {
            if (meeting != null)
            {
                this.dateMeetingDate.Value = meeting.Date;
                this.txtAddress.Text = meeting.Venue;
                List<Attendance> attendances = this.attendanceImpl.getAttendanceByMeetingId(meeting.Id);
                List<Member> attendees = new List<Member>();

                for (int i = 0; i < allAvailableMembers.Count; i++)
                {
                    this.clbxAttendees.SetItemChecked(i, false);
                }

                if (attendances.Count > 0)
                {
                    foreach (Attendance att in attendances)
                    {
                        attendees.Add(att.Attendee);
                    }
                    foreach (Member attendee in attendees)
                    {
                        for (int i = 0; i < allAvailableMembers.Count; i++)
                        {
                            if (allAvailableMembers[i].Id == attendee.Id)
                            {
                                this.clbxAttendees.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
                this.lblMeetingDate.Text = meeting.Date.ToLongDateString();
                this.lblPresenceCount.Text = attendances.Count.ToString() + " members.";
            }
            else
            {
                this.dateMeetingDate.Value = DateTime.Today;
                this.txtAddress.Text = "";
                foreach (int i in this.clbxAttendees.CheckedIndices)
                {
                    this.clbxAttendees.SetItemCheckState(i, CheckState.Unchecked);
                }
                this.lblMeetingDate.Text = this.dateMeetingDate.Value.ToLongDateString();
                this.lblPresenceCount.Text = "0 members";
            }
        }

        private void attendeesSelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPresenceCount.Text = this.clbxAttendees.CheckedItems.Count.ToString() + " members.";
            //WARNING: Keep track of checked attendees...
        }

        private void MeetingsListPopulator(List<Meeting> meetings)
        {
            this.lstMeetings.Clear();
            if (meetings.Count != 0 && meetings != null)
            {
                //This value represents all meetings we have displayed on screen!
                this.allAvailableMeetings = meetings;
                foreach (Meeting meeting in meetings)
                {
                    this.lstMeetings.Items.Add(meeting.Date.ToString("dd MMM yyyy")).BackColor = Color.Empty;
                }
            }
        }

        private void selectedTabChanged(object sender, TabControlEventArgs e)
        {
            connectionManager = new ConnectionManager();
            if (this.tabManager.SelectedTab == this.tabPageOptions)
            {
                Dictionary<string, string> smtpSetting = connectionManager.readSmtpSettings();
                if (smtpSetting != null)
                {
                    if (smtpSetting["hostName"].Contains("gmail"))
                    {
                        this.cbxEmailType.SelectedIndex = 0;
                    }
                    else if (smtpSetting["hostName"].Contains("yahoo"))
                    {
                        this.cbxEmailType.SelectedIndex = 1;
                    }
                    this.txtSenderNames.Text = smtpSetting["senderName"];
                    this.txtSenderEmail.Text = smtpSetting["senderEmail"];
                    this.txtSenderPassword.Text = smtpSetting["senderPassword"];
                }
            }
            else if (this.tabManager.SelectedTab == this.tabPageStatistics)
            {
                this.rdbGeneral.Checked = true;
                this.rdbPeriod.Checked = true;
                this.clbxMembers.Items.Clear();

                //Populate members checkListBox
                List<Member> allMembers = memberImpl.getAllMembers();

                if (allMembers != null && allMembers.Count != 0)
                {
                    foreach (Member member in memberImpl.getAllMembers())
                    {
                        this.clbxMembers.Items.Add(member.Lastname + " " + member.Firstname);
                    }
                }

                //Populate sex checkListBox
                Array sex = Enum.GetValues(typeof(Gender));
                foreach (Gender g in sex)
                {
                    if (!g.ToString().Equals(Gender.Unspecified.ToString()))
                    {
                        this.clbxSex.Items.Add(g.ToString());
                    }
                }

                //Populate meetings checkListBox
                List<Meeting> allMeetings = meetingImpl.getAllMeetings();
                if (allMeetings != null && allMeetings.Count != 0)
                {
                    foreach (Meeting meeting in allMeetings)
                    {
                        this.clbxMeetings.Items.Add(meeting.Date.ToString("dd MMM yyyy"));
                    }
                }
            }
        }

        private void anyRadioBtnCheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.grpCriteria.Controls)
            {
                if (control is RadioButton)
                {
                    if (this.rdbGeneral.Checked)
                    {
                        this.panelMembers.Enabled = false;
                        this.panelSex.Enabled = false;
                    }
                    else if (this.rdbBySex.Checked)
                    {
                        this.panelMembers.Enabled = false;
                        this.panelSex.Enabled = true;
                    }
                    else if (this.rdbByPerson.Checked)
                    {
                        this.panelMembers.Enabled = true;
                        this.panelSex.Enabled = false;
                    }
                }
            }
            foreach (Control control in this.panelPeriod.Controls)
            {
                if (control is RadioButton)
                {
                    if (this.rdbPeriod.Checked)
                    {
                        this.panelMeetings.Enabled = false;
                        this.dateFrom.Enabled = true;
                        this.dateTo.Enabled = true;
                    }
                    else if (this.rdbMeetings.Checked)
                    {
                        this.dateFrom.Enabled = false;
                        this.dateTo.Enabled = false;
                        this.panelMeetings.Enabled = true;
                    }
                }
            }
        }

        //Event listened by all "Tout" checkboxes...
        private void anyAllCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.grpSelection.Controls)
            {
                if (control is Panel)
                {
                    Panel panel = control as Panel;
                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is CheckBox)
                        {
                            CheckBox checkBox = panelControl as CheckBox;
                            foreach (Control otherPanelControl in checkBox.Parent.Controls)
                            {
                                if (otherPanelControl is CheckedListBox)
                                {
                                    CheckedListBox checkedListBox = otherPanelControl as CheckedListBox;
                                    if (checkBox.Checked)
                                    {
                                        for (int i = 0; i < checkedListBox.Items.Count; i++)
                                        {
                                            checkedListBox.SetItemChecked(i, true);
                                        }
                                    }
                                    else
                                    {
                                        if (this.allCheckBoxCheckedByUser)
                                        {
                                            for (int i = 0; i < checkedListBox.Items.Count; i++)
                                            {
                                                checkedListBox.SetItemChecked(i, false);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (panelControl is Panel)
                        {
                            Panel subPanel = panelControl as Panel;
                            foreach (Control subPanelControl in subPanel.Controls)
                            {
                                if (subPanelControl is CheckBox)
                                {
                                    CheckBox otherCheckBox = subPanelControl as CheckBox;
                                    foreach (Control checkedListBox in otherCheckBox.Parent.Controls)
                                    {
                                        if (checkedListBox is CheckedListBox)
                                        {
                                            CheckedListBox clbxMeetings = checkedListBox as CheckedListBox;
                                            if (otherCheckBox.Checked)
                                            {
                                                for (int i = 0; i < clbxMeetings.Items.Count; i++)
                                                {
                                                    clbxMeetings.SetItemChecked(i, true);
                                                }
                                            }
                                            else
                                            {
                                                if (this.allCheckBoxCheckedByUser)
                                                {
                                                    for (int i = 0; i < clbxMeetings.Items.Count; i++)
                                                    {
                                                        clbxMeetings.SetItemChecked(i, false);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void clbxSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.grpSelection.Controls)
            {
                if (control is Panel)
                {
                    Panel panel = control as Panel;
                    CheckedListBox checkedListBox = null;
                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is CheckedListBox)
                        {
                            checkedListBox = panelControl as CheckedListBox;
                            foreach (Control allChecker in checkedListBox.Parent.Controls)
                            {
                                if (allChecker is CheckBox)
                                {
                                    CheckBox checkBox = allChecker as CheckBox;
                                    this.allCheckBoxCheckedByUser = false;
                                    checkBox.Checked = false;
                                    this.allCheckBoxCheckedByUser = true;
                                }
                            }
                        }
                    }
                    if (checkedListBox == null)
                    {
                        foreach (Control panelControl in panel.Controls)
                        {
                            if (panelControl is Panel)
                            {
                                Panel subPanel = panelControl as Panel;
                                foreach (Control subPanelControl in subPanel.Controls)
                                {
                                    if (subPanelControl is CheckedListBox)
                                    {
                                        CheckedListBox subCheckedListBox = subPanelControl as CheckedListBox;
                                        foreach (Control parentControl in subCheckedListBox.Parent.Controls)
                                        {
                                            if (parentControl is CheckBox)
                                            {
                                                CheckBox subCheckBox = parentControl as CheckBox;
                                                this.allCheckBoxCheckedByUser = false;
                                                subCheckBox.Checked = false;
                                                this.allCheckBoxCheckedByUser = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, double>> points = new List<Dictionary<string, double>>();

            if (this.rdbGeneral.Checked)
            {
                points.Clear();
                if (this.clbxMembers.CheckedItems.Count != 0)
                {
                }
            }
            else if (this.rdbBySex.Checked)
            {
                points.Clear();

                List<Meeting> organizedMeetings = new List<Meeting>();
                if (this.rdbPeriod.Checked)
                {
                    organizedMeetings = this.meetingImpl.getMeetingsBetweenTwoDates(this.dateFrom.Value, this.dateTo.Value);

                }
                else if (this.rdbMeetings.Checked)
                {
                    organizedMeetings = new List<Meeting>();
                    for (int i = 0; i < this.clbxMeetings.CheckedItems.Count; i++)
                    {
                        organizedMeetings.Add(this.allAvailableMeetings[this.clbxMeetings.CheckedIndices[i]]);
                    }
                }

                Array sex = Enum.GetValues(typeof(Gender));
                System.Collections.IEnumerator sexEnumerator = sex.GetEnumerator();
                int indexer = 0;
                while (sexEnumerator.MoveNext() && sexEnumerator.Current != null && (Gender)sexEnumerator.Current != Gender.Unspecified)
                {
                    if ((indexer < this.clbxSex.CheckedItems.Count && this.clbxSex.CheckedItems[indexer].ToString().ToLower().
                        Equals(((Gender)sexEnumerator.Current).ToString().ToLower())) || this.clbxSex.CheckedItems.Count == 0)
                    {   
                        int attendeesCount = 0;
                        foreach (Member member in this.memberImpl.getAllMembers())
                        {
                            if (member.Sex == (Gender)sexEnumerator.Current)
                            {
                                if (this.memberImpl.didMemberAttendMultiMeetings(organizedMeetings, member))
                                {
                                    attendeesCount++;
                                }
                            }
                        }
                        Dictionary<string, double> point = new Dictionary<string, double>();
                        point.Add(((Gender)sexEnumerator.Current).ToString(), (attendeesCount / 
                            this.memberImpl.getMembersBySex((Gender)sexEnumerator.Current).Count) * 100);
                        points.Add(point);
                    }
                    indexer++;
                }
            }
            //Draw the chart
            this.chartAttendance.Series.Clear();
            for (int i = 0; i < points.Count; i++) {
                System.Collections.IEnumerator keyEnum = points[i].Keys.GetEnumerator();
                int indexer = 0;             
                while(keyEnum.MoveNext() && keyEnum.Current != null){
                    Series series = this.chartAttendance.Series.Add((string) keyEnum.Current);
                    series.Points.Add(points[indexer][(string)keyEnum.Current]);
                    indexer++;
                } 
            }
        }
    }
}