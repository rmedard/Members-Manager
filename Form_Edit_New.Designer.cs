namespace RNC
{
    partial class Form_Edit_New
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frm_Edit_New_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCardnum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnZapperPrev = new System.Windows.Forms.Button();
            this.btnZapperNext = new System.Windows.Forms.Button();
            this.lblZapper = new System.Windows.Forms.Label();
            this.dtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frm_Edit_New_title
            // 
            this.frm_Edit_New_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.frm_Edit_New_title.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm_Edit_New_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.frm_Edit_New_title.Location = new System.Drawing.Point(0, 0);
            this.frm_Edit_New_title.Name = "frm_Edit_New_title";
            this.frm_Edit_New_title.Size = new System.Drawing.Size(270, 18);
            this.frm_Edit_New_title.TabIndex = 0;
            this.frm_Edit_New_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sèxe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville(Province)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Téléphone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numéro Carte";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(92, 65);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(166, 20);
            this.txtLastname.TabIndex = 8;
            this.txtLastname.TextChanged += new System.EventHandler(this.lastnameChanged);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(92, 91);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(166, 20);
            this.txtFirstname.TabIndex = 9;
            this.txtFirstname.TextChanged += new System.EventHandler(this.firstnameChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 197);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtCardnum
            // 
            this.txtCardnum.Location = new System.Drawing.Point(92, 223);
            this.txtCardnum.Name = "txtCardnum";
            this.txtCardnum.Size = new System.Drawing.Size(166, 20);
            this.txtCardnum.TabIndex = 14;
            this.txtCardnum.TextChanged += new System.EventHandler(this.cardNumChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(92, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(183, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(92, 117);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(166, 21);
            this.cbxSex.TabIndex = 10;
            this.cbxSex.SelectedValueChanged += new System.EventHandler(this.selectionEvent);
            // 
            // cbxCity
            // 
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(92, 144);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(166, 21);
            this.cbxCity.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 299);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 19;
            this.lblErrorMessage.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // btnZapperPrev
            // 
            this.btnZapperPrev.Location = new System.Drawing.Point(12, 35);
            this.btnZapperPrev.Name = "btnZapperPrev";
            this.btnZapperPrev.Size = new System.Drawing.Size(21, 23);
            this.btnZapperPrev.TabIndex = 20;
            this.btnZapperPrev.Text = "<";
            this.btnZapperPrev.UseVisualStyleBackColor = true;
            this.btnZapperPrev.Click += new System.EventHandler(this.btnZapperPrev_Click);
            // 
            // btnZapperNext
            // 
            this.btnZapperNext.Location = new System.Drawing.Point(237, 35);
            this.btnZapperNext.Name = "btnZapperNext";
            this.btnZapperNext.Size = new System.Drawing.Size(21, 23);
            this.btnZapperNext.TabIndex = 21;
            this.btnZapperNext.Text = ">";
            this.btnZapperNext.UseVisualStyleBackColor = true;
            this.btnZapperNext.Click += new System.EventHandler(this.btnZapperNext_Click);
            // 
            // lblZapper
            // 
            this.lblZapper.AutoSize = true;
            this.lblZapper.Location = new System.Drawing.Point(123, 40);
            this.lblZapper.Name = "lblZapper";
            this.lblZapper.Size = new System.Drawing.Size(35, 13);
            this.lblZapper.TabIndex = 22;
            this.lblZapper.Text = "label1";
            // 
            // dtEntryDate
            // 
            this.dtEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntryDate.Location = new System.Drawing.Point(92, 249);
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Size = new System.Drawing.Size(166, 20);
            this.dtEntryDate.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date d\'entrée";
            // 
            // Form_Edit_New
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(270, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEntryDate);
            this.Controls.Add(this.lblZapper);
            this.Controls.Add(this.btnZapperNext);
            this.Controls.Add(this.btnZapperPrev);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCardnum);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frm_Edit_New_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form_Edit_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_Edit_New_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frm_Edit_New_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCardnum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnZapperPrev;
        private System.Windows.Forms.Button btnZapperNext;
        private System.Windows.Forms.Label lblZapper;
        private System.Windows.Forms.DateTimePicker dtEntryDate;
        private System.Windows.Forms.Label label1;
    }
}