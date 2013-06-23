namespace RNC
{
    partial class EasySelect
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
            this.cbxListSex = new System.Windows.Forms.CheckedListBox();
            this.cbxListProvince = new System.Windows.Forms.CheckedListBox();
            this.cbxAllSex = new System.Windows.Forms.CheckBox();
            this.cbxAllProvince = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxListSex
            // 
            this.cbxListSex.FormattingEnabled = true;
            this.cbxListSex.Location = new System.Drawing.Point(8, 41);
            this.cbxListSex.Name = "cbxListSex";
            this.cbxListSex.Size = new System.Drawing.Size(120, 94);
            this.cbxListSex.TabIndex = 0;
            this.cbxListSex.SelectedIndexChanged += new System.EventHandler(this.sexSelectedIndexChanged);
            // 
            // cbxListProvince
            // 
            this.cbxListProvince.FormattingEnabled = true;
            this.cbxListProvince.Location = new System.Drawing.Point(134, 41);
            this.cbxListProvince.Name = "cbxListProvince";
            this.cbxListProvince.Size = new System.Drawing.Size(120, 94);
            this.cbxListProvince.TabIndex = 1;
            this.cbxListProvince.SelectedIndexChanged += new System.EventHandler(this.provinceSelectedIndexChanged);
            // 
            // cbxAllSex
            // 
            this.cbxAllSex.AutoSize = true;
            this.cbxAllSex.Location = new System.Drawing.Point(8, 18);
            this.cbxAllSex.Name = "cbxAllSex";
            this.cbxAllSex.Size = new System.Drawing.Size(48, 17);
            this.cbxAllSex.TabIndex = 2;
            this.cbxAllSex.Text = "Tout";
            this.cbxAllSex.UseVisualStyleBackColor = true;
            this.cbxAllSex.CheckedChanged += new System.EventHandler(this.cbxAllSex_CheckedChanged);
            // 
            // cbxAllProvince
            // 
            this.cbxAllProvince.AutoSize = true;
            this.cbxAllProvince.Location = new System.Drawing.Point(134, 18);
            this.cbxAllProvince.Name = "cbxAllProvince";
            this.cbxAllProvince.Size = new System.Drawing.Size(48, 17);
            this.cbxAllProvince.TabIndex = 3;
            this.cbxAllProvince.Text = "Tout";
            this.cbxAllProvince.UseVisualStyleBackColor = true;
            this.cbxAllProvince.CheckedChanged += new System.EventHandler(this.cbxAllProvince_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxListProvince);
            this.groupBox1.Controls.Add(this.cbxAllProvince);
            this.groupBox1.Controls.Add(this.cbxListSex);
            this.groupBox1.Controls.Add(this.cbxAllSex);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Séléction";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(302, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(302, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(302, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EasySelect
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(389, 169);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EasySelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EasySelect";
            this.Load += new System.EventHandler(this.EasySelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbxListSex;
        private System.Windows.Forms.CheckedListBox cbxListProvince;
        private System.Windows.Forms.CheckBox cbxAllSex;
        private System.Windows.Forms.CheckBox cbxAllProvince;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
    }
}