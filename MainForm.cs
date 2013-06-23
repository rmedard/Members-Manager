using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using RNC.Entities;
using RNC.Implementors;
using RNC.Tools;
using RNC.Reporting;
using Excel;

namespace RNC
{
    public partial class MainForm : Form
    {
        private List<Member> selectedMembers;
        private List<Member> uploadedMembers;
        private List<Member> activeViewMembers;
        private Dictionary<int, Member> memberDict;
        private bool triggerSelectEvent = true;
        private MemberImpl memberImpl = new MemberImpl();

        public bool TriggerSelectEvent
        {
            get { return triggerSelectEvent; }
            set { triggerSelectEvent = value; }
        }

        public Dictionary<int, Member> MemberDict
        {
            get { return memberDict; }
            set { memberDict = value; }
        }

        public List<Member> SelectedMembers
        {
            get { return selectedMembers; }
            set { selectedMembers = value; }
        }

        public List<Member> UploadedMembers
        {
            get { return uploadedMembers; }
            set { uploadedMembers = value; }
        }

        public List<Member> ActiveViewMembers
        {
            get { return activeViewMembers; }
            set { activeViewMembers = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            selectedMembers = new List<Member>();
            this.ActiveViewMembers = new List<Member>();
            memberDict = new Dictionary<int, Member>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display(this.memberImpl.getAllMembers());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        //This is called everytime the DataGridView has to be changed!!!
        public void display(List<Member> members)
        {
            this.ActiveViewMembers = members;
            this.dataGridView.Rows.Clear();
            if (members != null && members.Count != 0)
            {
                this.dataGridView.Rows.Add(members.Count);
                //this.dataGridView.Rows[0].Selected = false;
                memberDict.Clear();
                for (int i = 0; i < members.Count; i++)
                {
                    Member member = members[i];
                    this.dataGridView.Rows[i].Cells[0].Value = i + 1;
                    this.memberDict.Add(i + 1, member);
                    this.dataGridView.Rows[i].Cells[1].Value = member.Lastname;
                    this.dataGridView.Rows[i].Cells[2].Value = member.Firstname;
                    this.dataGridView.Rows[i].Cells[3].Value = member.Sex;
                    this.dataGridView.Rows[i].Cells[4].Value = member.City;
                    this.dataGridView.Rows[i].Cells[5].Value = member.Email;
                    this.dataGridView.Rows[i].Cells[6].Value = member.Phone;
                    this.dataGridView.Rows[i].Cells[7].Value = member.Cardnum;
                    //this.dataGridView.Rows[i].ContextMenuStrip = this.cms_memberOptions;
                }
                this.dataGridView.Rows[0].Selected = false;
            }
            else
            {
                this.dataGridView.Rows.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnExit.PerformClick();
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            selectedMembers.Clear();
            if (this.MemberDict.Count > 0 && this.triggerSelectEvent)
            {
                foreach (DataGridViewRow row in this.dataGridView.SelectedRows)
                {
                    //I used Cells[0].Value because it holds the numero!
                    Member member = memberDict[int.Parse(row.Cells[0].Value.ToString())];
                    row.ContextMenuStrip = this.cms_memberOptions;
                    selectedMembers.Add(member);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedMembers.Count == 0)
            {
                ErrorMessageBox errorMessageBox = new ErrorMessageBox(this, "No selection made");
                errorMessageBox.ShowDialog();
            }
            else
            {
                Form_Edit_New form = new Form_Edit_New(this, this.selectedMembers);
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedMembers.Count > 0)
            {
                //ConfirmationBox conf = new ConfirmationBox();
                //conf.ShowDialog();
            }
            else if (this.selectedMembers.Count == 0)
            {
                ErrorMessageBox errorMessageBox = new ErrorMessageBox(this, "No selection made");
                errorMessageBox.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(this);
            aboutBox.ShowDialog();
        }

        private void easySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EasySelect easySelect = new EasySelect(this);
            easySelect.ShowDialog();
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            this.TriggerSelectEvent = false;
            display(this.memberImpl.getAllMembers());
            this.TriggerSelectEvent = true;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            Form_Edit_New form = new Form_Edit_New(this, this.selectedMembers);
            form.ShowDialog();
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            this.btnDelete.PerformClick();
        }

        private void rowRightClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //This is not working.... 
            //if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right) {
            //    this.dataGridView.Rows[e.RowIndex].ContextMenuStrip = this.cms_memberOptions;
            //    this.dataGridView.Rows[e.RowIndex].Selected = true;
            //    this.dataGridView.Rows[e.RowIndex].ContextMenuStrip.Show();
            //}
        }

        private void rowDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.dataGridView.Rows[e.RowIndex].Selected = true;
                Form_Edit_New form = new Form_Edit_New(this, this.selectedMembers);
                form.ShowDialog();
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailSender mailSender = new MailSender(this);
            mailSender.ShowDialog();
        }

        private void textSearchChanged(object sender, EventArgs e)
        {
            if (txtSearchToken.Text.Length == 0)
            {
                btnClearSelection.PerformClick();
                this.txtSearchToken.BackColor = System.Drawing.Color.White;
            }
            else
            {
                List<Member> searchReturn = new List<Member>();
                try
                {
                    if (this.cbxSearch.Text.Equals("Nom/Prénom".Trim()))
                    {
                        searchReturn.AddRange(this.memberImpl.getMembersByFirstOrLastName_Like(txtSearchToken.Text));
                    }
                    else if (this.cbxSearch.Text.Equals("Sèxe".Trim()))
                    {
                        searchReturn.AddRange(this.memberImpl.getMembersBySex(new Converter().stringToGender(txtSearchToken.Text)));
                    }
                    else if (this.cbxSearch.Text.Equals("Ville(Province)".Trim()))
                    {
                        searchReturn.AddRange(this.memberImpl.getMembersByProvince(new Converter().stringToCity(txtSearchToken.Text)));
                    }
                    else if (this.cbxSearch.Text.Equals("Téléphone".Trim()))
                    {
                        searchReturn.AddRange(this.memberImpl.getMembersByPhone_Like(this.txtSearchToken.Text));
                    }
                    else if (this.cbxSearch.Text.Equals("Numéro Carte".Trim()))
                    {
                        searchReturn.AddRange(this.memberImpl.getMemberByCardnum_Like(int.Parse(this.txtSearchToken.Text)));
                    }
                    else if (this.cbxSearch.Text.Length == 0)
                    {
                        searchReturn.AddRange(this.memberImpl.getMembersByFirstOrLastName_Like(txtSearchToken.Text));
                        searchReturn.AddRange(this.memberImpl.getMembersBySex(new Converter().stringToGender(txtSearchToken.Text)));
                        searchReturn.AddRange(this.memberImpl.getMembersByProvince(new Converter().stringToCity(txtSearchToken.Text)));
                        searchReturn.AddRange(this.memberImpl.getMembersByPhone_Like(this.txtSearchToken.Text));
                        searchReturn.AddRange(this.memberImpl.getMemberByCardnum_Like(int.Parse(this.txtSearchToken.Text)));
                    }
                }
                catch (Exception)
                {
                    //Iyo byananiranye...
                }

                if (searchReturn.Count == 0)
                {
                    this.txtSearchToken.BackColor = System.Drawing.Color.OrangeRed;
                }
                else
                {
                    this.txtSearchToken.BackColor = System.Drawing.Color.PaleGreen;
                }
                this.triggerSelectEvent = false;
                this.display(searchReturn);
                this.triggerSelectEvent = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            EasySelectPrint easySelectPrint = new EasySelectPrint(this);
            easySelectPrint.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Edit_New form = new Form_Edit_New(this, null);
            form.ShowDialog();
        }

        private void searchCbxTextChanged(object sender, EventArgs e)
        {

        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Title = "Select Excel File";
            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Filter = "MS Office Excel File(*.xls, *xlsx)|*.xls; *xlsx";
            Converter converter = new Converter();
            if (this.openFileDialog.ShowDialog() == DialogResult.OK) {
                string dirName = Path.GetFullPath(this.openFileDialog.FileName);
                FileStream stream = File.Open(dirName, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                //excelReader.IsFirstRowAsColumnNames = true;
                //DataSet result = excelReader.AsDataSet();
                
                if (excelReader.ResultsCount > 0)
                {
                    List<Member> newMembers = new List<Member>();
                    while (excelReader.Read())
                    {
                        Member member = new Member();
                        member.IsValid = true;
                        member.Lastname = excelReader.GetString(0);
                        member.Firstname = excelReader.GetString(1);
                        if (member.Lastname.Length == 0 || member.Firstname.Length == 0) {
                            member.IsValid = false;
                        }
                        string thisMemberSex = excelReader.GetString(2).ToLower();
                        try
                        {
                            member.Sex = converter.stringToGender(thisMemberSex);
                        }
                        catch (Exception) {
                            member.Sex = Gender.Unspecified;
                            member.IsValid = false;
                        }
                        string thisMemberCity = excelReader.GetString(3).ToLower();
                        try
                        {
                            member.City = converter.stringToCity(thisMemberCity);
                        }
                        catch (Exception) {
                            member.City = Province.Unspecified;
                            member.IsValid = false;
                        }
                        member.Email = excelReader.GetString(4).ToLower();
                        if (!(member.Email.Contains("@") || member.Email.Contains(".") || member.Email.IndexOf("@") > 0 || member.Email.LastIndexOf(".") > member.Email.IndexOf("@")))
                        {
                            member.IsValid = false;
                        }
                        member.Phone = excelReader.GetString(5);
                        try
                        {
                            member.Cardnum = excelReader.GetInt16(6);
                        }
                        catch (FormatException) {
                            member.IsValid = false;
                        }
                        newMembers.Add(member);
                    }
                    this.uploadedMembers = newMembers;
                    //Create a file upload manager...
                    ExcelFileUploader fileUploader = new ExcelFileUploader(this);
                    fileUploader.ShowDialog();
                }
                excelReader.Close();
            }
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management management = new Management(this);
            management.ShowDialog();
        }
    }
}
