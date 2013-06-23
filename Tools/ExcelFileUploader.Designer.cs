namespace RNC.Tools
{
    partial class ExcelFileUploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelFileUploader));
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtCardnum = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPassed = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.rdbNewDB = new System.Windows.Forms.RadioButton();
            this.rdbAppend = new System.Windows.Forms.RadioButton();
            this.lstViewMembers = new System.Windows.Forms.ListView();
            this.dateTimeEntry = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCity
            // 
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(165, 91);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(138, 21);
            this.cbxCity.TabIndex = 18;
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(165, 64);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(138, 21);
            this.cbxSex.TabIndex = 17;
            // 
            // txtCardnum
            // 
            this.txtCardnum.Location = new System.Drawing.Point(165, 170);
            this.txtCardnum.Name = "txtCardnum";
            this.txtCardnum.Size = new System.Drawing.Size(138, 20);
            this.txtCardnum.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(165, 144);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(138, 20);
            this.txtPhone.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(165, 38);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(138, 20);
            this.txtFirstname.TabIndex = 16;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(165, 12);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(138, 20);
            this.txtLastname.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Location = new System.Drawing.Point(25, 3);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(35, 13);
            this.lblPassed.TabIndex = 24;
            this.lblPassed.Text = "label1";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Location = new System.Drawing.Point(25, 28);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(35, 13);
            this.lblFailed.TabIndex = 25;
            this.lblFailed.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblFailed);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblPassed);
            this.panel1.Location = new System.Drawing.Point(165, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 44);
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.rdbNewDB);
            this.groupBox1.Controls.Add(this.rdbAppend);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 71);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(210, 13);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // rdbNewDB
            // 
            this.rdbNewDB.AutoSize = true;
            this.rdbNewDB.Location = new System.Drawing.Point(6, 42);
            this.rdbNewDB.Name = "rdbNewDB";
            this.rdbNewDB.Size = new System.Drawing.Size(135, 17);
            this.rdbNewDB.TabIndex = 1;
            this.rdbNewDB.TabStop = true;
            this.rdbNewDB.Text = "Créer une nouvelle liste";
            this.rdbNewDB.UseVisualStyleBackColor = true;
            // 
            // rdbAppend
            // 
            this.rdbAppend.AutoSize = true;
            this.rdbAppend.Location = new System.Drawing.Point(6, 19);
            this.rdbAppend.Name = "rdbAppend";
            this.rdbAppend.Size = new System.Drawing.Size(99, 17);
            this.rdbAppend.TabIndex = 0;
            this.rdbAppend.TabStop = true;
            this.rdbAppend.Text = "Ajouter à la liste";
            this.rdbAppend.UseVisualStyleBackColor = true;
            // 
            // lstViewMembers
            // 
            this.lstViewMembers.Location = new System.Drawing.Point(12, 12);
            this.lstViewMembers.MultiSelect = false;
            this.lstViewMembers.Name = "lstViewMembers";
            this.lstViewMembers.Size = new System.Drawing.Size(147, 255);
            this.lstViewMembers.TabIndex = 28;
            this.lstViewMembers.UseCompatibleStateImageBehavior = false;
            this.lstViewMembers.SelectedIndexChanged += new System.EventHandler(this.SelectedMemberChanged);
            // 
            // dateTimeEntry
            // 
            this.dateTimeEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEntry.Location = new System.Drawing.Point(165, 196);
            this.dateTimeEntry.Name = "dateTimeEntry";
            this.dateTimeEntry.Size = new System.Drawing.Size(138, 20);
            this.dateTimeEntry.TabIndex = 29;
            // 
            // ExcelFileUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 356);
            this.Controls.Add(this.dateTimeEntry);
            this.Controls.Add(this.lstViewMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.txtCardnum);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExcelFileUploader";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ExcelFileUploader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txtCardnum;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton rdbNewDB;
        private System.Windows.Forms.RadioButton rdbAppend;
        private System.Windows.Forms.ListView lstViewMembers;
        private System.Windows.Forms.DateTimePicker dateTimeEntry;

    }
}