using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RNC.Entities;
using RNC.Implementors;

namespace RNC.Reporting
{
    public partial class EasySelectPrint : Form
    {
        private MainForm parentForm;
        private MemberImpl memberImpl = new MemberImpl();
        private MeetingImpl meetingImpl = new MeetingImpl();
        private bool allCheckBoxCheckedByUser = true;
        private List<Meeting> allAvailableMeetings;

        internal List<Meeting> AllAvailableMeetings
        {
            get { return allAvailableMeetings; }
            //set { allAvailableMeetings = value; }
        }

        public EasySelectPrint(MainForm mainForm)
        {
            InitializeComponent();
            this.parentForm = mainForm;
            this.rdbPeriod.Checked = true;
            allAvailableMeetings = new List<Meeting>();

            Array sex = Enum.GetValues(typeof(Gender));
            Array provinces = Enum.GetValues(typeof(Province));
            foreach (Gender g in sex)
            {
                if (!g.ToString().Equals("Unspecified"))
                {
                    this.clbxSex.Items.Add(g.ToString());
                }
            }
            foreach (Province p in provinces)
            {
                if (!p.ToString().Equals("Unspecified"))
                {
                    this.clbxProvince.Items.Add(p.ToString());
                }
            }

            foreach (Meeting meeting in this.meetingImpl.getAllMeetings())
            {
                this.clbxMeetings.Items.Add(meeting.Date.ToString("dd MMM yyyy"));
                this.AllAvailableMeetings.Add(meeting);
            }

            this.clbxDetails.SetItemChecked(0, true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cbxAllProvince.Checked = true;
            this.cbxAllProvince.Checked = false;
            this.cbxAllSex.Checked = true;
            this.cbxAllSex.Checked = false;
            this.cbxAllDetails.Checked = true;
            this.cbxAllDetails.Checked = false;
            this.cbxAllMeetings.Checked = true;
            this.cbxAllMeetings.Checked = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Member> cityAndSexSelection = new List<Member>();
            List<Member> printableList = new List<Member>();
            Array sex = Enum.GetValues(typeof(Gender));
            Array provinces = Enum.GetValues(typeof(Province));
            if (this.rdbPrintNewSelection.Checked)
            {
                if (clbxSex.CheckedItems.Count == 1)
                {
                    cityAndSexSelection.Clear();
                    foreach (Gender g in sex)
                    {
                        if (clbxSex.CheckedItems[0].ToString().ToLower().Equals(g.ToString().ToLower()))
                        {
                            if (clbxProvince.CheckedItems.Count < clbxProvince.Items.Count && clbxProvince.CheckedItems.Count > 0)
                            {
                                foreach (Province p in provinces)
                                {
                                    for (int i = 0; i < clbxProvince.CheckedItems.Count; i++)
                                    {
                                        if (clbxProvince.CheckedItems[i].ToString().ToLower().Equals(p.ToString().ToLower()))
                                        {
                                            cityAndSexSelection.AddRange(this.memberImpl.getMembersBySexAndProvince(g, p));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                cityAndSexSelection.AddRange(this.memberImpl.getMembersBySex(g));
                            }
                        }
                    }
                }
                else
                {
                    cityAndSexSelection.Clear();
                    if (clbxProvince.CheckedItems.Count < clbxProvince.Items.Count && clbxProvince.CheckedItems.Count > 0)
                    {
                        foreach (Province p in provinces)
                        {
                            for (int i = 0; i < clbxProvince.CheckedItems.Count; i++)
                            {
                                if (clbxProvince.CheckedItems[i].ToString().ToLower().Equals(p.ToString().ToLower()))
                                {
                                    cityAndSexSelection.AddRange(this.memberImpl.getMembersByProvince(p));
                                }
                            }
                        }
                    }
                    else
                    {
                        cityAndSexSelection.AddRange(this.memberImpl.getAllMembers());
                    }
                }

                #region checkingAttendance
                
                //Pass the selection through attendance checking
                List<Member> attendees = new List<Member>();
                if (this.rdbPeriod.Checked)
                {
                    List<Meeting> organizedMeetings = new List<Meeting>();
                    foreach (Meeting meeting in this.meetingImpl.getAllMeetings())
                    {
                        if (DateTime.Compare(meeting.Date, this.dateFrom.Value) >= 0 && DateTime.Compare(meeting.Date, this.dateTo.Value) <= 0)
                        {
                            organizedMeetings.Add(meeting);
                        }
                    }
                    if (organizedMeetings.Count > 0)
                    {
                        foreach (Member member in cityAndSexSelection)
                        {
                            if (this.memberImpl.didMemberAttendMultiMeetings(organizedMeetings, member))
                            {
                                attendees.Add(member);
                            }
                        }
                    }
                }
                else if (this.rdbMeetings.Checked)
                {
                    if (this.clbxMeetings.CheckedItems.Count < this.clbxMeetings.Items.Count && this.clbxMeetings.CheckedItems.Count > 0)
                    {
                        List<Meeting> checkedMeetings = new List<Meeting>();
                        for (int i = 0; i < this.clbxMeetings.CheckedItems.Count; i++)
                        {
                            checkedMeetings.Add(this.allAvailableMeetings[this.clbxMeetings.CheckedIndices[i]]);
                        }
                        foreach (Member member in cityAndSexSelection)
                        {
                            if (this.memberImpl.didMemberAttendMultiMeetings(checkedMeetings, member)) {
                                attendees.Add(member);
                            }
                        }
                    }
                    else
                    {
                        foreach (Member member in cityAndSexSelection)
                        {
                            if (this.memberImpl.didMemberAttendMultiMeetings(this.meetingImpl.getAllMeetings(), member))
                            {
                                attendees.Add(member);
                            }
                        }
                    }
                }
                printableList = attendees;
            }
            else
            {
                if (this.parentForm.SelectedMembers.Count > 0)
                {
                    printableList = this.parentForm.SelectedMembers;
                }
                else
                {
                    printableList = this.parentForm.ActiveViewMembers;
                }
            }
                #endregion

            #region checkingDetails
            string reportOrder = "";
            for (int i = 0; i < this.clbxDetails.CheckedItems.Count; i++)
            {
                if (this.clbxDetails.GetItemChecked(i))
                {
                    reportOrder += i.ToString();
                }
            }
            #endregion
            MemberReportViewer memberReportViewer = new MemberReportViewer();
            memberReportViewer.PrintableList = printableList;
            memberReportViewer.ReportOrder = reportOrder;
            memberReportViewer.ShowDialog();
        }

        private void sexClbxSelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxesChecker(this.clbxSex);
        }

        private void cityClbxSelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxesChecker(this.clbxProvince);
        }

        private void meetingsClbxSelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxesChecker(this.clbxMeetings);
        }

        private void checkedListBoxesChecker(CheckedListBox clbx)
        {
            foreach (Control allChecker in clbx.Parent.Controls)
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

        private void allCheckBoxesChecker(CheckBox cbx)
        {
            foreach (Control otherPanelControl in cbx.Parent.Controls)
            {
                if (otherPanelControl is CheckedListBox)
                {
                    CheckedListBox checkedListBox = otherPanelControl as CheckedListBox;
                    if (cbx.Checked)
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

        private void sexAllCheckedChanged(object sender, EventArgs e)
        {
            allCheckBoxesChecker(this.cbxAllSex);
        }

        private void cityAllCheckedChanged(object sender, EventArgs e)
        {
            allCheckBoxesChecker(this.cbxAllProvince);
        }

        private void meetingsAllCheckedChanged(object sender, EventArgs e)
        {
            allCheckBoxesChecker(this.cbxAllMeetings);
        }

        private void rdbSelectionCheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbPrintView.Checked)
            {
                this.grpSelection.Enabled = false;
                this.btnReset.Enabled = false;
            }
            else
            {
                this.grpSelection.Enabled = true;
                this.btnReset.Enabled = true;
            }
        }

        private void rdbMeetingPeriodCheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbPeriod.Checked)
            {
                this.dateFrom.Enabled = true;
                this.dateTo.Enabled = true;
                this.panelMeetings.Enabled = false;
                //This removes any checkes in clbxMeetings
                this.cbxAllMeetings.Checked = true;
                this.cbxAllMeetings.Checked = false;
            }
            else if (this.rdbMeetings.Checked)
            {
                this.dateFrom.Enabled = false;
                this.dateTo.Enabled = false;
                this.panelMeetings.Enabled = true;
            }
        }

        private void detailsClbxSelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxesChecker(this.clbxDetails);
            this.clbxDetails.SetItemChecked(0, true);
        }

        private void detailsAllCheckedChanged(object sender, EventArgs e)
        {
            allCheckBoxesChecker(this.cbxAllDetails);
            this.clbxDetails.SetItemChecked(0, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
