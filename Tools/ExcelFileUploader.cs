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

namespace RNC.Tools
{
    public partial class ExcelFileUploader : Form
    {
        private MainForm parentForm;
        private int validMembers;
        private int invalidMembers = 0;

        public ExcelFileUploader(MainForm mainForm)
        {
            InitializeComponent();
            this.parentForm = mainForm;
        }

        public int InvalidMembers
        {
            get { return invalidMembers; }
            set
            {
                invalidMembers = value;
                validMembers = this.parentForm.UploadedMembers.Count - invalidMembers;
                for (int i = 0; i < this.parentForm.UploadedMembers.Count; i++) {
                    if (!this.parentForm.UploadedMembers[i].IsValid)
                    {
                        this.lstViewMembers.Items[i].BackColor = Color.OrangeRed;
                    }
                    else {
                        this.lstViewMembers.Items[i].BackColor = Color.Empty;
                    }
                }
                this.lblFailed.Text = invalidMembers + " incomplets";
                this.lblPassed.Text = validMembers + " complets";
            }
        }

        private void ExcelFileUploader_Load(object sender, EventArgs e)
        {
            this.dateTimeEntry.Format = DateTimePickerFormat.Custom;
            this.dateTimeEntry.CustomFormat = "dd MMM yyyy";

            foreach (Member member in parentForm.UploadedMembers)
            {
                this.lstViewMembers.Items.Add(member.Lastname + " " + member.Firstname);
                if (!member.IsValid)
                {
                    invalidMembers++;
                }
            }

        }

        private void SelectedMemberChanged(object sender, EventArgs e)
        {
            Member selectedMember = this.parentForm.UploadedMembers[this.lstViewMembers.SelectedIndices[0]];
            this.txtLastname.Text = selectedMember.Lastname;
            this.txtFirstname.Text = selectedMember.Firstname;
            Array sex = Enum.GetValues(typeof(Gender));
            foreach (Gender g in sex)
            {
                if (selectedMember.Sex == g)
                {
                    for (int i = 0; i < this.cbxSex.Items.Count; i++)
                    {
                        if (g.ToString().Equals(this.cbxSex.Items[i]))
                        {
                            this.cbxSex.SelectedIndex = i;
                            break;
                        }
                    }
                    break;
                }
            }
            Array provinces = Enum.GetValues(typeof(Province));
            foreach (Province p in provinces)
            {
                if (selectedMember.City == p)
                {
                    for (int i = 0; i < this.cbxCity.Items.Count; i++)
                    {
                        if (p.ToString().Equals(this.cbxCity.Items[i]))
                        {
                            this.cbxCity.SelectedIndex = i;
                            break;
                        }
                    }
                    break;
                }
            }
            this.txtEmail.Text = selectedMember.Email;
            this.txtPhone.Text = selectedMember.Phone;
            this.txtCardnum.Text = selectedMember.Cardnum.ToString();
        }
    }
}
