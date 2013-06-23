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

namespace RNC
{
    public partial class EasySelect : Form
    {
        private MainForm parentForm;
        private bool userTriggered;
        private MemberImpl memberImpl = new MemberImpl();

        public EasySelect(MainForm mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            userTriggered = true;

            Array sex = Enum.GetValues(typeof(Gender));
            Array provinces = Enum.GetValues(typeof(Province));
            foreach (Gender g in sex)
            {
                if (!g.ToString().Equals("Unspecified"))
                {
                    this.cbxListSex.Items.Add(g.ToString()); 
                }
            }
            foreach (Province p in provinces)
            {
                if (!p.ToString().Equals("Unspecified"))
                {
                    this.cbxListProvince.Items.Add(p.ToString()); 
                }
            }
            this.cbxListSex.CheckOnClick = true;
            this.cbxListProvince.CheckOnClick = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxAllSex_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAllSex.Checked)
            {
                for (int i = 0; i < cbxListSex.Items.Count; i++)
                {
                    cbxListSex.SetItemChecked(i, true);
                }
            }
            else
            {
                if (this.userTriggered)
                {
                    for (int i = 0; i < cbxListSex.Items.Count; i++)
                    {
                        cbxListSex.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void cbxAllProvince_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAllProvince.Checked)
            {
                for (int i = 0; i < cbxListProvince.Items.Count; i++)
                {
                    cbxListProvince.SetItemChecked(i, true);
                }
            }
            else
            {
                if (this.userTriggered)
                {
                    for (int i = 0; i < cbxListProvince.Items.Count; i++)
                    {
                        cbxListProvince.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void sexSelectedIndexChanged(object sender, EventArgs e)
        {
            //bool state = false;
            this.userTriggered = false;
            cbxAllSex.Checked = false;
            this.userTriggered = true;
        }

        private void provinceSelectedIndexChanged(object sender, EventArgs e)
        {
            //bool state = false;
            this.userTriggered = false;
            cbxAllProvince.Checked = false;
            this.userTriggered = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cbxAllProvince.Checked = true;
            this.cbxAllProvince.Checked = false;
            this.cbxAllSex.Checked = true;
            this.cbxAllSex.Checked = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Member> selection = new List<Member>(); ;
            Array sex = Enum.GetValues(typeof(Gender));
            Array provinces = Enum.GetValues(typeof(Province));
            if (cbxListSex.CheckedItems.Count == 1)
            {
                foreach (Gender g in sex)
                {
                    if (cbxListSex.CheckedItems[0].ToString().Equals(g.ToString()))
                    {
                        if (cbxListProvince.CheckedItems.Count < cbxListProvince.Items.Count && cbxListProvince.CheckedItems.Count > 0)
                        {
                            foreach (Province p in provinces)
                            {
                                for (int i = 0; i < cbxListProvince.CheckedItems.Count; i++)
                                {
                                    if (cbxListProvince.CheckedItems[i].ToString().Equals(p.ToString()))
                                    {
                                        selection.AddRange(this.memberImpl.getMembersBySexAndProvince(g, p));
                                    }
                                }
                            }
                        }
                        else
                        {
                            selection.AddRange(this.memberImpl.getMembersBySex(g));
                        }
                    }
                }
            }
            else
            {
                if (cbxListProvince.CheckedItems.Count < cbxListProvince.Items.Count && cbxListProvince.CheckedItems.Count > 0)
                {
                    foreach (Province p in provinces)
                    {
                        for (int i = 0; i < cbxListProvince.CheckedItems.Count; i++)
                        {
                            if (cbxListProvince.CheckedItems[i].ToString().Equals(p.ToString()))
                            {
                                selection.AddRange(this.memberImpl.getMembersByProvince(p));
                            }
                        }
                    }
                }
                else if (cbxListProvince.CheckedItems.Count == cbxListProvince.Items.Count || cbxListSex.CheckedItems.Count == cbxListSex.Items.Count)
                {
                    selection.AddRange(this.memberImpl.getAllMembers());
                }
                else if (cbxListSex.CheckedItems.Count == 0 && cbxListProvince.CheckedItems.Count == 0)
                {
                    this.Close();
                }
            }
            this.parentForm.TriggerSelectEvent = false;
            this.parentForm.display(selection);
            this.parentForm.TriggerSelectEvent = true;
        }

        private void EasySelect_Load(object sender, EventArgs e)
        {

        }
    }
}
