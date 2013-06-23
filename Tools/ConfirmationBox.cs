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

namespace RNC.Tools
{
    public partial class ConfirmationBox : Form
    {
        private bool delete = false;

        public bool Delete
        {
            get { return delete; }
            set { delete = value; }
        }
        
        public ConfirmationBox()
        {
            InitializeComponent();
            this.lblMessage.Text = "Etes-vous sûr?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Delete = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Delete = false;
            this.Close();
        }
    }
}
