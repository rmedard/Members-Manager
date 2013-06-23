namespace RNC.Reporting
{
    partial class EasySelectPrint
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
            this.grpSelection = new System.Windows.Forms.GroupBox();
            this.panelPeriod = new System.Windows.Forms.Panel();
            this.panelMeetings = new System.Windows.Forms.Panel();
            this.clbxMeetings = new System.Windows.Forms.CheckedListBox();
            this.cbxAllMeetings = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdbMeetings = new System.Windows.Forms.RadioButton();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.rdbPeriod = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clbxProvince = new System.Windows.Forms.CheckedListBox();
            this.cbxAllProvince = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbxSex = new System.Windows.Forms.CheckedListBox();
            this.cbxAllSex = new System.Windows.Forms.CheckBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cbxAllDetails = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbxDetails = new System.Windows.Forms.CheckedListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlPrintNewSelection = new System.Windows.Forms.Panel();
            this.rdbPrintView = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdbPrintNewSelection = new System.Windows.Forms.RadioButton();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.grpSelection.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.panelMeetings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.pnlPrintNewSelection.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelection
            // 
            this.grpSelection.Controls.Add(this.panelPeriod);
            this.grpSelection.Controls.Add(this.panel2);
            this.grpSelection.Controls.Add(this.panel1);
            this.grpSelection.Location = new System.Drawing.Point(11, 54);
            this.grpSelection.Name = "grpSelection";
            this.grpSelection.Size = new System.Drawing.Size(325, 299);
            this.grpSelection.TabIndex = 5;
            this.grpSelection.TabStop = false;
            this.grpSelection.Text = "Séléction";
            // 
            // panelPeriod
            // 
            this.panelPeriod.Controls.Add(this.panelMeetings);
            this.panelPeriod.Controls.Add(this.label7);
            this.panelPeriod.Controls.Add(this.dateFrom);
            this.panelPeriod.Controls.Add(this.rdbMeetings);
            this.panelPeriod.Controls.Add(this.dateTo);
            this.panelPeriod.Controls.Add(this.rdbPeriod);
            this.panelPeriod.Location = new System.Drawing.Point(7, 154);
            this.panelPeriod.Name = "panelPeriod";
            this.panelPeriod.Size = new System.Drawing.Size(310, 139);
            this.panelPeriod.TabIndex = 9;
            // 
            // panelMeetings
            // 
            this.panelMeetings.Controls.Add(this.clbxMeetings);
            this.panelMeetings.Controls.Add(this.cbxAllMeetings);
            this.panelMeetings.Location = new System.Drawing.Point(74, 30);
            this.panelMeetings.Name = "panelMeetings";
            this.panelMeetings.Size = new System.Drawing.Size(231, 103);
            this.panelMeetings.TabIndex = 5;
            // 
            // clbxMeetings
            // 
            this.clbxMeetings.CheckOnClick = true;
            this.clbxMeetings.FormattingEnabled = true;
            this.clbxMeetings.Location = new System.Drawing.Point(57, 3);
            this.clbxMeetings.Name = "clbxMeetings";
            this.clbxMeetings.Size = new System.Drawing.Size(142, 94);
            this.clbxMeetings.TabIndex = 1;
            this.clbxMeetings.SelectedIndexChanged += new System.EventHandler(this.meetingsClbxSelectedIndexChanged);
            // 
            // cbxAllMeetings
            // 
            this.cbxAllMeetings.AutoSize = true;
            this.cbxAllMeetings.Location = new System.Drawing.Point(3, 3);
            this.cbxAllMeetings.Name = "cbxAllMeetings";
            this.cbxAllMeetings.Size = new System.Drawing.Size(48, 17);
            this.cbxAllMeetings.TabIndex = 0;
            this.cbxAllMeetings.Text = "Tout";
            this.cbxAllMeetings.UseVisualStyleBackColor = true;
            this.cbxAllMeetings.CheckedChanged += new System.EventHandler(this.meetingsAllCheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "-";
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(74, 3);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(104, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // rdbMeetings
            // 
            this.rdbMeetings.AutoSize = true;
            this.rdbMeetings.Location = new System.Drawing.Point(4, 29);
            this.rdbMeetings.Name = "rdbMeetings";
            this.rdbMeetings.Size = new System.Drawing.Size(70, 17);
            this.rdbMeetings.TabIndex = 1;
            this.rdbMeetings.TabStop = true;
            this.rdbMeetings.Text = "Réunions";
            this.rdbMeetings.UseVisualStyleBackColor = true;
            this.rdbMeetings.CheckedChanged += new System.EventHandler(this.rdbMeetingPeriodCheckedChanged);
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(201, 3);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(104, 20);
            this.dateTo.TabIndex = 3;
            // 
            // rdbPeriod
            // 
            this.rdbPeriod.AutoSize = true;
            this.rdbPeriod.Location = new System.Drawing.Point(4, 5);
            this.rdbPeriod.Name = "rdbPeriod";
            this.rdbPeriod.Size = new System.Drawing.Size(64, 17);
            this.rdbPeriod.TabIndex = 0;
            this.rdbPeriod.TabStop = true;
            this.rdbPeriod.Text = "Période:";
            this.rdbPeriod.UseVisualStyleBackColor = true;
            this.rdbPeriod.CheckedChanged += new System.EventHandler(this.rdbMeetingPeriodCheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clbxProvince);
            this.panel2.Controls.Add(this.cbxAllProvince);
            this.panel2.Location = new System.Drawing.Point(168, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 129);
            this.panel2.TabIndex = 1;
            // 
            // clbxProvince
            // 
            this.clbxProvince.CheckOnClick = true;
            this.clbxProvince.FormattingEnabled = true;
            this.clbxProvince.Location = new System.Drawing.Point(4, 25);
            this.clbxProvince.Name = "clbxProvince";
            this.clbxProvince.Size = new System.Drawing.Size(140, 94);
            this.clbxProvince.TabIndex = 1;
            this.clbxProvince.SelectedIndexChanged += new System.EventHandler(this.cityClbxSelectedIndexChanged);
            // 
            // cbxAllProvince
            // 
            this.cbxAllProvince.AutoSize = true;
            this.cbxAllProvince.Location = new System.Drawing.Point(4, 2);
            this.cbxAllProvince.Name = "cbxAllProvince";
            this.cbxAllProvince.Size = new System.Drawing.Size(48, 17);
            this.cbxAllProvince.TabIndex = 3;
            this.cbxAllProvince.Text = "Tout";
            this.cbxAllProvince.UseVisualStyleBackColor = true;
            this.cbxAllProvince.CheckedChanged += new System.EventHandler(this.cityAllCheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clbxSex);
            this.panel1.Controls.Add(this.cbxAllSex);
            this.panel1.Location = new System.Drawing.Point(8, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 129);
            this.panel1.TabIndex = 0;
            // 
            // clbxSex
            // 
            this.clbxSex.CheckOnClick = true;
            this.clbxSex.FormattingEnabled = true;
            this.clbxSex.Location = new System.Drawing.Point(3, 26);
            this.clbxSex.Name = "clbxSex";
            this.clbxSex.Size = new System.Drawing.Size(142, 94);
            this.clbxSex.TabIndex = 0;
            this.clbxSex.SelectedIndexChanged += new System.EventHandler(this.sexClbxSelectedIndexChanged);
            // 
            // cbxAllSex
            // 
            this.cbxAllSex.AutoSize = true;
            this.cbxAllSex.Location = new System.Drawing.Point(3, 3);
            this.cbxAllSex.Name = "cbxAllSex";
            this.cbxAllSex.Size = new System.Drawing.Size(48, 17);
            this.cbxAllSex.TabIndex = 2;
            this.cbxAllSex.Text = "Tout";
            this.cbxAllSex.UseVisualStyleBackColor = true;
            this.cbxAllSex.CheckedChanged += new System.EventHandler(this.sexAllCheckedChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.cbxAllDetails);
            this.grpDetails.Controls.Add(this.btnCancel);
            this.grpDetails.Controls.Add(this.clbxDetails);
            this.grpDetails.Controls.Add(this.btnPrint);
            this.grpDetails.Location = new System.Drawing.Point(12, 3);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(324, 145);
            this.grpDetails.TabIndex = 6;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Détails à imprimer";
            // 
            // cbxAllDetails
            // 
            this.cbxAllDetails.AutoSize = true;
            this.cbxAllDetails.Location = new System.Drawing.Point(6, 19);
            this.cbxAllDetails.Name = "cbxAllDetails";
            this.cbxAllDetails.Size = new System.Drawing.Size(48, 17);
            this.cbxAllDetails.TabIndex = 1;
            this.cbxAllDetails.Text = "Tout";
            this.cbxAllDetails.UseVisualStyleBackColor = true;
            this.cbxAllDetails.CheckedChanged += new System.EventHandler(this.detailsAllCheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clbxDetails
            // 
            this.clbxDetails.CheckOnClick = true;
            this.clbxDetails.FormattingEnabled = true;
            this.clbxDetails.Items.AddRange(new object[] {
            "Coordonées générales",
            "N° Carte",
            "Date d\'entrée",
            "Présence(%)"});
            this.clbxDetails.Location = new System.Drawing.Point(6, 42);
            this.clbxDetails.Name = "clbxDetails";
            this.clbxDetails.Size = new System.Drawing.Size(141, 94);
            this.clbxDetails.TabIndex = 0;
            this.clbxDetails.SelectedIndexChanged += new System.EventHandler(this.detailsClbxSelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(235, 42);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlPrintNewSelection
            // 
            this.pnlPrintNewSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrintNewSelection.Controls.Add(this.rdbPrintView);
            this.pnlPrintNewSelection.Controls.Add(this.btnReset);
            this.pnlPrintNewSelection.Controls.Add(this.rdbPrintNewSelection);
            this.pnlPrintNewSelection.Controls.Add(this.grpSelection);
            this.pnlPrintNewSelection.Location = new System.Drawing.Point(10, 11);
            this.pnlPrintNewSelection.Name = "pnlPrintNewSelection";
            this.pnlPrintNewSelection.Size = new System.Drawing.Size(345, 366);
            this.pnlPrintNewSelection.TabIndex = 7;
            // 
            // rdbPrintView
            // 
            this.rdbPrintView.AutoSize = true;
            this.rdbPrintView.Location = new System.Drawing.Point(3, 3);
            this.rdbPrintView.Name = "rdbPrintView";
            this.rdbPrintView.Size = new System.Drawing.Size(156, 17);
            this.rdbPrintView.TabIndex = 0;
            this.rdbPrintView.TabStop = true;
            this.rdbPrintView.Text = "Imprimer la séléction en vue";
            this.rdbPrintView.UseVisualStyleBackColor = true;
            this.rdbPrintView.CheckedChanged += new System.EventHandler(this.rdbSelectionCheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(261, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdbPrintNewSelection
            // 
            this.rdbPrintNewSelection.AutoSize = true;
            this.rdbPrintNewSelection.Location = new System.Drawing.Point(3, 29);
            this.rdbPrintNewSelection.Name = "rdbPrintNewSelection";
            this.rdbPrintNewSelection.Size = new System.Drawing.Size(112, 17);
            this.rdbPrintNewSelection.TabIndex = 7;
            this.rdbPrintNewSelection.TabStop = true;
            this.rdbPrintNewSelection.Text = "Nouvelle séléction";
            this.rdbPrintNewSelection.UseVisualStyleBackColor = true;
            this.rdbPrintNewSelection.CheckedChanged += new System.EventHandler(this.rdbSelectionCheckedChanged);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.grpDetails);
            this.pnlDetails.Location = new System.Drawing.Point(10, 383);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(345, 161);
            this.pnlDetails.TabIndex = 11;
            // 
            // EasySelectPrint
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(365, 551);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlPrintNewSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EasySelectPrint";
            this.Text = "EasySelectPrint";
            this.grpSelection.ResumeLayout(false);
            this.panelPeriod.ResumeLayout(false);
            this.panelPeriod.PerformLayout();
            this.panelMeetings.ResumeLayout(false);
            this.panelMeetings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.pnlPrintNewSelection.ResumeLayout(false);
            this.pnlPrintNewSelection.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelection;
        private System.Windows.Forms.CheckedListBox clbxProvince;
        private System.Windows.Forms.CheckBox cbxAllProvince;
        private System.Windows.Forms.CheckedListBox clbxSex;
        private System.Windows.Forms.CheckBox cbxAllSex;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.CheckBox cbxAllDetails;
        private System.Windows.Forms.CheckedListBox clbxDetails;
        private System.Windows.Forms.Panel pnlPrintNewSelection;
        private System.Windows.Forms.RadioButton rdbPrintNewSelection;
        private System.Windows.Forms.RadioButton rdbPrintView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel panelPeriod;
        private System.Windows.Forms.Panel panelMeetings;
        private System.Windows.Forms.CheckedListBox clbxMeetings;
        private System.Windows.Forms.CheckBox cbxAllMeetings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.RadioButton rdbMeetings;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.RadioButton rdbPeriod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}