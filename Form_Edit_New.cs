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
using RNC.Tools;

namespace RNC
{
    public partial class Form_Edit_New : Form
    {
        private bool newRecord;
        private MemberImpl memberImpl;
        private MainForm parentForm;
        private int activeMemberIndex;
        private List<Member> editMembers;
        private Converter converter;

        internal MemberImpl MemberImpl
        {
            get { return memberImpl; }
            set { memberImpl = value; }
        }

        public bool NewRecord
        {
            get { return newRecord; }
            set { newRecord = value; }
        }

        //Constructs a new Edit form for a new entry or an edit session...
        public Form_Edit_New(MainForm mainForm, List<Member> members)
        {
            InitializeComponent();
            parentForm = mainForm;
            memberImpl = new MemberImpl();
            converter = new Converter();

            this.cbxSex.Items.AddRange(new Object[] { Gender.Female.ToString(), Gender.Male.ToString() });
            this.cbxCity.Items.AddRange(new Object[]{Province.Anvers.ToString(), Province.Bruxelles.ToString(), 
                Province.Charleroi.ToString(), Province.Liège.ToString(), Province.Namur.ToString(), 
                Province.Etranger.ToString()});
            if (members != null)
            {
                this.NewRecord = false;
                this.btnSave.Enabled = true;
                this.editMembers = members;
                this.editMembers.Reverse();
                this.activeMemberIndex = 0;
                this.zapper(activeMemberIndex);
                this.btnZapperNext.Enabled = true;
                this.btnZapperPrev.Enabled = true;
            }
            else
            {
                this.NewRecord = true;
                this.editMembers = null;
                this.btnSave.Enabled = false;
                this.btnZapperNext.Enabled = false;
                this.btnZapperPrev.Enabled = false;
                this.lblZapper.Text = "1/1";
            }
        }

        private void frm_Edit_New_Load(object sender, EventArgs e)
        {
            if (this.newRecord)
            {
                this.frm_Edit_New_title.Text = "Nouvelle Entrée";
                this.Text = "New Member";
            }
            else
            {
                this.frm_Edit_New_title.Text = "Modifier";
                this.Text = "Update Member";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member newMember;

            Member member = new Member();
            member.Lastname = this.txtLastname.Text;
            member.Firstname = this.txtFirstname.Text;
            try
            {
                member.Sex = this.converter.stringToGender(cbxSex.SelectedItem.ToString());
                member.City = this.converter.stringToCity(cbxCity.SelectedItem.ToString());
            }
            catch (Exception)
            {
                lblErrorMessage.Text = "Sèxe incorrect...";
            }
            member.Email = this.txtEmail.Text;
            member.Phone = this.txtPhone.Text;
            member.Cardnum = int.Parse(this.txtCardnum.Text);
            member.EntryDate = this.dtEntryDate.Value;

            if (this.newRecord)
            {
                newMember = memberImpl.addMember(member);
            }
            else
            {
                member.Id = this.editMembers[this.activeMemberIndex].Id;
                newMember = memberImpl.updateMember(member);
            }
            if (newMember != null)
            {
                //This disables selectionChanged event to be triggered
                parentForm.TriggerSelectEvent = false;
                parentForm.display(memberImpl.getAllMembers());
                parentForm.TriggerSelectEvent = true;
                this.Close();
            }
        }

        private bool isFormValid()
        {
            if (this.txtLastname.Text.Trim().Length != 0 && this.txtFirstname.Text.Trim().Length != 0 && this.cbxSex.SelectedIndex >= 0)
            {
                return true;
            }
            return false;
        }

        private bool isCardValid()
        {
            bool checker;
            try
            {
                if (this.txtCardnum.Text.Trim().Length > 0)
                {
                    int cardnum = int.Parse(this.txtCardnum.Text.Trim());
                    lblErrorMessage.Text = "";
                    if (memberImpl.getMemberByCardnum(cardnum).Count == 1 && (this.newRecord || (this.editMembers[activeMemberIndex].Cardnum != cardnum && !this.newRecord)))
                    {
                        lblErrorMessage.Text = "Numéro déjà utilisé...";
                        checker = false;
                    }
                    checker = true;
                }
                else
                {
                    lblErrorMessage.Text = "";
                    checker = true;
                }
            }
            catch (FormatException)
            {
                lblErrorMessage.Text = "Numéro incorrect...";
                checker = false;
            }
            return checker;
        }

        private void lastnameChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = isFormValid() ? true : false;
            if (this.doesFullNamesExist(this.txtFirstname.Text, this.txtLastname.Text))
            {
                this.txtLastname.BackColor = Color.PaleVioletRed;
                this.txtFirstname.BackColor = Color.PaleVioletRed;
            }
            else {
                if (this.doesNameExist(this.txtLastname.Text))
                {
                    this.txtLastname.BackColor = Color.PaleGreen;
                }
                else
                {
                    this.txtLastname.BackColor = Color.Empty;
                }

                if (this.doesNameExist(this.txtFirstname.Text))
                {
                    this.txtFirstname.BackColor = Color.PaleGreen;
                }
                else
                {
                    this.txtFirstname.BackColor = Color.Empty;
                }
            }
        }

        private void firstnameChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = isFormValid() ? true : false;
            if (this.doesFullNamesExist(this.txtFirstname.Text, this.txtLastname.Text))
            {
                this.txtLastname.BackColor = Color.PaleVioletRed;
                this.txtFirstname.BackColor = Color.PaleVioletRed;
            }
            else {
                if (this.doesNameExist(this.txtFirstname.Text))
                {
                    this.txtFirstname.BackColor = Color.PaleGreen;
                }
                else
                {
                    this.txtFirstname.BackColor = Color.Empty;
                }

                if (this.doesNameExist(this.txtLastname.Text))
                {
                    this.txtLastname.BackColor = Color.PaleGreen;
                }
                else {
                    this.txtLastname.BackColor = Color.Empty;    
                }
            }
        }

        private void selectionEvent(object sender, EventArgs e)
        {
            this.btnSave.Enabled = isFormValid() ? true : false;
        }

        private void cardNumChanged(object sender, EventArgs e)
        {
            isCardValid();
        }

        //This function swaps through selected members to edit!! 
        private void zapper(int index)
        {
            if (index == 0 && index == this.editMembers.Count - 1)
            {
                this.btnZapperPrev.Enabled = false;
                this.btnZapperNext.Enabled = false;
            }
            else if (index == 0 && index < this.editMembers.Count - 1)
            {
                this.btnZapperPrev.Enabled = false;
                this.btnZapperNext.Enabled = true;
            }
            else if (index > 0 && index == this.editMembers.Count - 1)
            {
                this.btnZapperPrev.Enabled = true;
                this.btnZapperNext.Enabled = false;
            }
            else if (index > 0 && index < this.editMembers.Count - 1)
            {
                this.btnZapperPrev.Enabled = true;
                this.btnZapperNext.Enabled = true;
            }

            this.lblZapper.Text = (index + 1).ToString() + "/" + this.editMembers.Count;

            Member member = this.editMembers[index];

            this.txtLastname.Text = member.Lastname;
            this.txtFirstname.Text = member.Firstname;
            Array sex = Enum.GetValues(typeof(Gender));
            foreach (Gender g in sex)
            {
                if (member.Sex == g)
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
                if (member.City == p)
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
            this.txtEmail.Text = member.Email;
            this.txtPhone.Text = member.Phone;
            this.txtCardnum.Text = member.Cardnum.ToString();
        }

        private void btnZapperPrev_Click(object sender, EventArgs e)
        {
            activeMemberIndex -= 1;
            this.zapper(activeMemberIndex);
        }

        private void btnZapperNext_Click(object sender, EventArgs e)
        {
            activeMemberIndex += 1;
            this.zapper(activeMemberIndex);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.btnZapperNext.PerformClick();
            }
            if (e.KeyCode == Keys.Left)
            {
                this.btnZapperPrev.PerformClick();
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = lblErrorMessage.Text.Length > 0 ? false : true;
        }

        private bool doesNameExist(string name)
        {
            if (this.memberImpl.getMembersByFirstOrLastname(name).Count > 0 && (this.newRecord || (!this.editMembers[activeMemberIndex].Firstname.Equals(name) || !this.editMembers[activeMemberIndex].Lastname.Equals(name))))
            {
                return true;
            }
            return false;
        }

        private bool doesFullNamesExist(string firstname, string lastname) {
            if (this.memberImpl.getMembersByFirstnameAndLastname(firstname, lastname).Count > 0 && (this.newRecord || !(this.editMembers[activeMemberIndex].Firstname.Equals(firstname) && this.editMembers[activeMemberIndex].Lastname.Equals(lastname)))) {
                return true;
            } 
            return false;
        }
    }
}