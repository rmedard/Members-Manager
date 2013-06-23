namespace RNC
{
    partial class MailSender
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
            this.txtAreaMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtCopyReceiver = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cbxCopyToSelf = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAttach = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnAddAttach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelAttach.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAreaMessage
            // 
            this.txtAreaMessage.Location = new System.Drawing.Point(15, 88);
            this.txtAreaMessage.Name = "txtAreaMessage";
            this.txtAreaMessage.Size = new System.Drawing.Size(545, 287);
            this.txtAreaMessage.TabIndex = 0;
            this.txtAreaMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Récipiendaires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copie(CC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sujet";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(95, 5);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(465, 20);
            this.txtReceiver.TabIndex = 4;
            // 
            // txtCopyReceiver
            // 
            this.txtCopyReceiver.Location = new System.Drawing.Point(95, 31);
            this.txtCopyReceiver.Multiline = true;
            this.txtCopyReceiver.Name = "txtCopyReceiver";
            this.txtCopyReceiver.Size = new System.Drawing.Size(465, 20);
            this.txtCopyReceiver.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(95, 57);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(465, 20);
            this.txtSubject.TabIndex = 6;
            // 
            // cbxCopyToSelf
            // 
            this.cbxCopyToSelf.AutoSize = true;
            this.cbxCopyToSelf.Location = new System.Drawing.Point(11, 523);
            this.cbxCopyToSelf.Name = "cbxCopyToSelf";
            this.cbxCopyToSelf.Size = new System.Drawing.Size(93, 17);
            this.cbxCopyToSelf.TabIndex = 7;
            this.cbxCopyToSelf.Text = "Copie pour soi";
            this.cbxCopyToSelf.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(400, 520);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnAddAttach);
            this.groupBox1.Location = new System.Drawing.Point(15, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attacher des fichiers";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panelAttach);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 85);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelAttach
            // 
            this.panelAttach.Controls.Add(this.btnBrowse);
            this.panelAttach.Controls.Add(this.txtFilename);
            this.panelAttach.Controls.Add(this.lblFile);
            this.panelAttach.Location = new System.Drawing.Point(3, 3);
            this.panelAttach.Name = "panelAttach";
            this.panelAttach.Size = new System.Drawing.Size(422, 27);
            this.panelAttach.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(355, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(51, 3);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(298, 20);
            this.txtFilename.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(7, 7);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(38, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Fichier";
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Location = new System.Drawing.Point(6, 105);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAddAttach.TabIndex = 3;
            this.btnAddAttach.Text = "+ Fichier";
            this.btnAddAttach.UseVisualStyleBackColor = true;
            // 
            // MailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbxCopyToSelf);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCopyReceiver);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAreaMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailSender";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.MailSender_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelAttach.ResumeLayout(false);
            this.panelAttach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAreaMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtCopyReceiver;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.CheckBox cbxCopyToSelf;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelAttach;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnAddAttach;
    }
}