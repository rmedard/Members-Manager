namespace RNC
{
    partial class Management
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabManager = new System.Windows.Forms.TabControl();
            this.tabPageMeetings = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPresenceCount = new System.Windows.Forms.Label();
            this.lblMeetingDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchToCheck = new System.Windows.Forms.TextBox();
            this.clbxAttendees = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteMeeting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstMeetings = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateMeetingDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSaveMeeting = new System.Windows.Forms.Button();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.grpObservation = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblMeetingsCount = new System.Windows.Forms.Label();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panelSex = new System.Windows.Forms.Panel();
            this.cbxAllSex = new System.Windows.Forms.CheckBox();
            this.clbxSex = new System.Windows.Forms.CheckedListBox();
            this.panelMembers = new System.Windows.Forms.Panel();
            this.cbxAllMembers = new System.Windows.Forms.CheckBox();
            this.clbxMembers = new System.Windows.Forms.CheckedListBox();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.rdbByPerson = new System.Windows.Forms.RadioButton();
            this.rdbBySex = new System.Windows.Forms.RadioButton();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblEmailOptionsSavedStatus = new System.Windows.Forms.Label();
            this.lblEmailOptionsStatus = new System.Windows.Forms.Label();
            this.btnCancelOptions = new System.Windows.Forms.Button();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.txtSenderPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSenderNames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEmailType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabManager.SuspendLayout();
            this.tabPageMeetings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageStatistics.SuspendLayout();
            this.grpObservation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            this.grpSelection.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.panelMeetings.SuspendLayout();
            this.panelSex.SuspendLayout();
            this.panelMembers.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManager
            // 
            this.tabManager.Controls.Add(this.tabPageMeetings);
            this.tabManager.Controls.Add(this.tabPageStatistics);
            this.tabManager.Controls.Add(this.tabPageOptions);
            this.tabManager.Location = new System.Drawing.Point(0, 0);
            this.tabManager.Name = "tabManager";
            this.tabManager.SelectedIndex = 0;
            this.tabManager.Size = new System.Drawing.Size(696, 513);
            this.tabManager.TabIndex = 0;
            this.tabManager.Selected += new System.Windows.Forms.TabControlEventHandler(this.selectedTabChanged);
            // 
            // tabPageMeetings
            // 
            this.tabPageMeetings.Controls.Add(this.lblStatus);
            this.tabPageMeetings.Controls.Add(this.groupBox3);
            this.tabPageMeetings.Controls.Add(this.groupBox2);
            this.tabPageMeetings.Controls.Add(this.btnDeleteMeeting);
            this.tabPageMeetings.Controls.Add(this.groupBox1);
            this.tabPageMeetings.Controls.Add(this.btnSaveMeeting);
            this.tabPageMeetings.Controls.Add(this.btnCreateMeeting);
            this.tabPageMeetings.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeetings.Name = "tabPageMeetings";
            this.tabPageMeetings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeetings.Size = new System.Drawing.Size(688, 487);
            this.tabPageMeetings.TabIndex = 0;
            this.tabPageMeetings.Text = "Réunions/Présences";
            this.tabPageMeetings.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(6, 464);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.TextChanged += new System.EventHandler(this.statusTextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPresenceCount);
            this.groupBox3.Controls.Add(this.lblMeetingDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(130, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 81);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overview";
            // 
            // lblPresenceCount
            // 
            this.lblPresenceCount.AutoSize = true;
            this.lblPresenceCount.Location = new System.Drawing.Point(162, 49);
            this.lblPresenceCount.Name = "lblPresenceCount";
            this.lblPresenceCount.Size = new System.Drawing.Size(35, 13);
            this.lblPresenceCount.TabIndex = 3;
            this.lblPresenceCount.Text = "label6";
            // 
            // lblMeetingDate
            // 
            this.lblMeetingDate.AutoSize = true;
            this.lblMeetingDate.Location = new System.Drawing.Point(87, 29);
            this.lblMeetingDate.Name = "lblMeetingDate";
            this.lblMeetingDate.Size = new System.Drawing.Size(35, 13);
            this.lblMeetingDate.TabIndex = 2;
            this.lblMeetingDate.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de membres présents:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "La réunion du:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchToCheck);
            this.groupBox2.Controls.Add(this.clbxAttendees);
            this.groupBox2.Location = new System.Drawing.Point(435, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 438);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Présences";
            this.groupBox2.Leave += new System.EventHandler(this.AttendeesListFocusLost);
            // 
            // txtSearchToCheck
            // 
            this.txtSearchToCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchToCheck.Location = new System.Drawing.Point(6, 412);
            this.txtSearchToCheck.Name = "txtSearchToCheck";
            this.txtSearchToCheck.Size = new System.Drawing.Size(194, 20);
            this.txtSearchToCheck.TabIndex = 10;
            this.txtSearchToCheck.TextChanged += new System.EventHandler(this.txtSearchToCheckTextChanged);
            // 
            // clbxAttendees
            // 
            this.clbxAttendees.CheckOnClick = true;
            this.clbxAttendees.FormattingEnabled = true;
            this.clbxAttendees.Location = new System.Drawing.Point(6, 19);
            this.clbxAttendees.Name = "clbxAttendees";
            this.clbxAttendees.Size = new System.Drawing.Size(194, 379);
            this.clbxAttendees.TabIndex = 9;
            this.clbxAttendees.SelectedIndexChanged += new System.EventHandler(this.attendeesSelectedIndexChanged);
            // 
            // btnDeleteMeeting
            // 
            this.btnDeleteMeeting.Location = new System.Drawing.Point(8, 421);
            this.btnDeleteMeeting.Name = "btnDeleteMeeting";
            this.btnDeleteMeeting.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteMeeting.TabIndex = 7;
            this.btnDeleteMeeting.Text = "Supprimer";
            this.btnDeleteMeeting.UseVisualStyleBackColor = true;
            this.btnDeleteMeeting.Click += new System.EventHandler(this.btnDeleteMeeting_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMeetings);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateMeetingDate);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 351);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réunions";
            // 
            // lstMeetings
            // 
            this.lstMeetings.Location = new System.Drawing.Point(6, 19);
            this.lstMeetings.MultiSelect = false;
            this.lstMeetings.Name = "lstMeetings";
            this.lstMeetings.Size = new System.Drawing.Size(121, 318);
            this.lstMeetings.TabIndex = 0;
            this.lstMeetings.UseCompatibleStateImageBehavior = false;
            this.lstMeetings.View = System.Windows.Forms.View.List;
            this.lstMeetings.SelectedIndexChanged += new System.EventHandler(this.meetingsSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // dateMeetingDate
            // 
            this.dateMeetingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMeetingDate.Location = new System.Drawing.Point(194, 84);
            this.dateMeetingDate.Name = "dateMeetingDate";
            this.dateMeetingDate.Size = new System.Drawing.Size(180, 20);
            this.dateMeetingDate.TabIndex = 3;
            this.dateMeetingDate.ValueChanged += new System.EventHandler(this.selectedMeetingDateValueChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(194, 115);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 77);
            this.txtAddress.TabIndex = 4;
            // 
            // btnSaveMeeting
            // 
            this.btnSaveMeeting.Location = new System.Drawing.Point(8, 392);
            this.btnSaveMeeting.Name = "btnSaveMeeting";
            this.btnSaveMeeting.Size = new System.Drawing.Size(116, 23);
            this.btnSaveMeeting.TabIndex = 6;
            this.btnSaveMeeting.Text = "Sauvegarder";
            this.btnSaveMeeting.UseVisualStyleBackColor = true;
            this.btnSaveMeeting.Click += new System.EventHandler(this.btnSaveMeeting_Click);
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.Location = new System.Drawing.Point(8, 363);
            this.btnCreateMeeting.Name = "btnCreateMeeting";
            this.btnCreateMeeting.Size = new System.Drawing.Size(116, 23);
            this.btnCreateMeeting.TabIndex = 5;
            this.btnCreateMeeting.Text = "Créer une réunion";
            this.btnCreateMeeting.UseVisualStyleBackColor = true;
            this.btnCreateMeeting.Click += new System.EventHandler(this.btnCreateMeeting_Click);
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Controls.Add(this.grpObservation);
            this.tabPageStatistics.Controls.Add(this.grpSelection);
            this.tabPageStatistics.Controls.Add(this.grpCriteria);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(688, 487);
            this.tabPageStatistics.TabIndex = 1;
            this.tabPageStatistics.Text = "Statistiques";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // grpObservation
            // 
            this.grpObservation.Controls.Add(this.panel5);
            this.grpObservation.Location = new System.Drawing.Point(8, 220);
            this.grpObservation.Name = "grpObservation";
            this.grpObservation.Size = new System.Drawing.Size(671, 261);
            this.grpObservation.TabIndex = 2;
            this.grpObservation.TabStop = false;
            this.grpObservation.Text = "Observation";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.lblMeetingsCount);
            this.panel5.Controls.Add(this.chartAttendance);
            this.panel5.Controls.Add(this.lblPeriod);
            this.panel5.Controls.Add(this.lblTitle);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(6, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 236);
            this.panel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Location = new System.Drawing.Point(3, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 60);
            this.panel1.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Visualiser";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblMeetingsCount
            // 
            this.lblMeetingsCount.AutoSize = true;
            this.lblMeetingsCount.Location = new System.Drawing.Point(21, 134);
            this.lblMeetingsCount.Name = "lblMeetingsCount";
            this.lblMeetingsCount.Size = new System.Drawing.Size(41, 13);
            this.lblMeetingsCount.TabIndex = 5;
            this.lblMeetingsCount.Text = "label13";
            // 
            // chartAttendance
            // 
            this.chartAttendance.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Area3DStyle.Inclination = 5;
            chartArea1.BackColor = System.Drawing.Color.LightGreen;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.BorderColor = System.Drawing.Color.Green;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 72.15385F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chartAttendance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAttendance.Legends.Add(legend1);
            this.chartAttendance.Location = new System.Drawing.Point(125, 8);
            this.chartAttendance.Name = "chartAttendance";
            this.chartAttendance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartAttendance.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DarkGreen};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Présence";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartAttendance.Series.Add(series1);
            this.chartAttendance.Size = new System.Drawing.Size(526, 221);
            this.chartAttendance.TabIndex = 6;
            this.chartAttendance.Text = "chartAttendance";
            title1.Alignment = System.Drawing.ContentAlignment.TopRight;
            title1.DockedToChartArea = "ChartArea1";
            title1.Name = "title";
            title1.Text = "Iyi ni titre";
            this.chartAttendance.Titles.Add(title1);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(21, 83);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(41, 13);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "label12";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(21, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nr Réunions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Période:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Titre:";
            // 
            // grpSelection
            // 
            this.grpSelection.Controls.Add(this.panelPeriod);
            this.grpSelection.Controls.Add(this.panelSex);
            this.grpSelection.Controls.Add(this.panelMembers);
            this.grpSelection.Location = new System.Drawing.Point(8, 59);
            this.grpSelection.Name = "grpSelection";
            this.grpSelection.Size = new System.Drawing.Size(671, 155);
            this.grpSelection.TabIndex = 1;
            this.grpSelection.TabStop = false;
            this.grpSelection.Text = "Sélection";
            // 
            // panelPeriod
            // 
            this.panelPeriod.Controls.Add(this.panelMeetings);
            this.panelPeriod.Controls.Add(this.label7);
            this.panelPeriod.Controls.Add(this.dateFrom);
            this.panelPeriod.Controls.Add(this.rdbMeetings);
            this.panelPeriod.Controls.Add(this.dateTo);
            this.panelPeriod.Controls.Add(this.rdbPeriod);
            this.panelPeriod.Location = new System.Drawing.Point(326, 19);
            this.panelPeriod.Name = "panelPeriod";
            this.panelPeriod.Size = new System.Drawing.Size(339, 130);
            this.panelPeriod.TabIndex = 4;
            // 
            // panelMeetings
            // 
            this.panelMeetings.Controls.Add(this.clbxMeetings);
            this.panelMeetings.Controls.Add(this.cbxAllMeetings);
            this.panelMeetings.Location = new System.Drawing.Point(74, 30);
            this.panelMeetings.Name = "panelMeetings";
            this.panelMeetings.Size = new System.Drawing.Size(262, 97);
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
            this.clbxMeetings.SelectedIndexChanged += new System.EventHandler(this.clbxSelectedIndexChanged);
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
            this.cbxAllMeetings.CheckedChanged += new System.EventHandler(this.anyAllCheckBoxCheckedChanged);
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
            this.rdbMeetings.CheckedChanged += new System.EventHandler(this.anyRadioBtnCheckedChanged);
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
            this.rdbPeriod.CheckedChanged += new System.EventHandler(this.anyRadioBtnCheckedChanged);
            // 
            // panelSex
            // 
            this.panelSex.Controls.Add(this.cbxAllSex);
            this.panelSex.Controls.Add(this.clbxSex);
            this.panelSex.Location = new System.Drawing.Point(194, 19);
            this.panelSex.Name = "panelSex";
            this.panelSex.Size = new System.Drawing.Size(126, 130);
            this.panelSex.TabIndex = 3;
            // 
            // cbxAllSex
            // 
            this.cbxAllSex.AutoSize = true;
            this.cbxAllSex.Location = new System.Drawing.Point(3, 7);
            this.cbxAllSex.Name = "cbxAllSex";
            this.cbxAllSex.Size = new System.Drawing.Size(48, 17);
            this.cbxAllSex.TabIndex = 0;
            this.cbxAllSex.Text = "Tout";
            this.cbxAllSex.UseVisualStyleBackColor = true;
            this.cbxAllSex.CheckedChanged += new System.EventHandler(this.anyAllCheckBoxCheckedChanged);
            // 
            // clbxSex
            // 
            this.clbxSex.CheckOnClick = true;
            this.clbxSex.FormattingEnabled = true;
            this.clbxSex.Location = new System.Drawing.Point(3, 30);
            this.clbxSex.Name = "clbxSex";
            this.clbxSex.Size = new System.Drawing.Size(120, 94);
            this.clbxSex.TabIndex = 1;
            this.clbxSex.SelectedIndexChanged += new System.EventHandler(this.clbxSelectedIndexChanged);
            // 
            // panelMembers
            // 
            this.panelMembers.Controls.Add(this.cbxAllMembers);
            this.panelMembers.Controls.Add(this.clbxMembers);
            this.panelMembers.Location = new System.Drawing.Point(6, 19);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(182, 130);
            this.panelMembers.TabIndex = 2;
            // 
            // cbxAllMembers
            // 
            this.cbxAllMembers.AutoSize = true;
            this.cbxAllMembers.Location = new System.Drawing.Point(3, 6);
            this.cbxAllMembers.Name = "cbxAllMembers";
            this.cbxAllMembers.Size = new System.Drawing.Size(50, 17);
            this.cbxAllMembers.TabIndex = 0;
            this.cbxAllMembers.Text = "Tous";
            this.cbxAllMembers.UseVisualStyleBackColor = true;
            this.cbxAllMembers.CheckedChanged += new System.EventHandler(this.anyAllCheckBoxCheckedChanged);
            // 
            // clbxMembers
            // 
            this.clbxMembers.CheckOnClick = true;
            this.clbxMembers.FormattingEnabled = true;
            this.clbxMembers.Location = new System.Drawing.Point(3, 29);
            this.clbxMembers.Name = "clbxMembers";
            this.clbxMembers.Size = new System.Drawing.Size(176, 94);
            this.clbxMembers.TabIndex = 0;
            this.clbxMembers.SelectedIndexChanged += new System.EventHandler(this.clbxSelectedIndexChanged);
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.rdbByPerson);
            this.grpCriteria.Controls.Add(this.rdbBySex);
            this.grpCriteria.Controls.Add(this.rdbGeneral);
            this.grpCriteria.Location = new System.Drawing.Point(8, 6);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(243, 47);
            this.grpCriteria.TabIndex = 0;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Critère";
            // 
            // rdbByPerson
            // 
            this.rdbByPerson.AutoSize = true;
            this.rdbByPerson.Location = new System.Drawing.Point(146, 19);
            this.rdbByPerson.Name = "rdbByPerson";
            this.rdbByPerson.Size = new System.Drawing.Size(85, 17);
            this.rdbByPerson.TabIndex = 2;
            this.rdbByPerson.TabStop = true;
            this.rdbByPerson.Text = "Par individus";
            this.rdbByPerson.UseVisualStyleBackColor = true;
            this.rdbByPerson.CheckedChanged += new System.EventHandler(this.anyRadioBtnCheckedChanged);
            // 
            // rdbBySex
            // 
            this.rdbBySex.AutoSize = true;
            this.rdbBySex.Location = new System.Drawing.Point(74, 19);
            this.rdbBySex.Name = "rdbBySex";
            this.rdbBySex.Size = new System.Drawing.Size(66, 17);
            this.rdbBySex.TabIndex = 1;
            this.rdbBySex.TabStop = true;
            this.rdbBySex.Text = "Par sèxe";
            this.rdbBySex.UseVisualStyleBackColor = true;
            this.rdbBySex.CheckedChanged += new System.EventHandler(this.anyRadioBtnCheckedChanged);
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Location = new System.Drawing.Point(6, 19);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdbGeneral.TabIndex = 0;
            this.rdbGeneral.TabStop = true;
            this.rdbGeneral.Text = "Général";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            this.rdbGeneral.CheckedChanged += new System.EventHandler(this.anyRadioBtnCheckedChanged);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.groupBox7);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(688, 487);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblEmailOptionsSavedStatus);
            this.groupBox7.Controls.Add(this.lblEmailOptionsStatus);
            this.groupBox7.Controls.Add(this.btnCancelOptions);
            this.groupBox7.Controls.Add(this.btnSaveOptions);
            this.groupBox7.Controls.Add(this.txtSenderEmail);
            this.groupBox7.Controls.Add(this.txtSenderPassword);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.txtSenderNames);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.cbxEmailType);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(8, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(437, 142);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Options Email";
            // 
            // lblEmailOptionsSavedStatus
            // 
            this.lblEmailOptionsSavedStatus.AutoSize = true;
            this.lblEmailOptionsSavedStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailOptionsSavedStatus.Location = new System.Drawing.Point(0, 126);
            this.lblEmailOptionsSavedStatus.Name = "lblEmailOptionsSavedStatus";
            this.lblEmailOptionsSavedStatus.Size = new System.Drawing.Size(0, 16);
            this.lblEmailOptionsSavedStatus.TabIndex = 11;
            this.lblEmailOptionsSavedStatus.TextChanged += new System.EventHandler(this.statusTextChanged);
            // 
            // lblEmailOptionsStatus
            // 
            this.lblEmailOptionsStatus.AutoSize = true;
            this.lblEmailOptionsStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEmailOptionsStatus.Location = new System.Drawing.Point(3, 126);
            this.lblEmailOptionsStatus.Name = "lblEmailOptionsStatus";
            this.lblEmailOptionsStatus.Size = new System.Drawing.Size(0, 13);
            this.lblEmailOptionsStatus.TabIndex = 10;
            // 
            // btnCancelOptions
            // 
            this.btnCancelOptions.Location = new System.Drawing.Point(345, 41);
            this.btnCancelOptions.Name = "btnCancelOptions";
            this.btnCancelOptions.Size = new System.Drawing.Size(86, 23);
            this.btnCancelOptions.TabIndex = 6;
            this.btnCancelOptions.Text = "Annuler";
            this.btnCancelOptions.UseVisualStyleBackColor = true;
            this.btnCancelOptions.Click += new System.EventHandler(this.btnCancelOptions_Click);
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(345, 12);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(86, 23);
            this.btnSaveOptions.TabIndex = 5;
            this.btnSaveOptions.Text = "Sauvegarder";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(129, 70);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(169, 20);
            this.txtSenderEmail.TabIndex = 3;
            this.txtSenderEmail.TextChanged += new System.EventHandler(this.optionsTextChanged);
            this.txtSenderEmail.Leave += new System.EventHandler(this.txtSenderEmailFocusLost);
            // 
            // txtSenderPassword
            // 
            this.txtSenderPassword.Location = new System.Drawing.Point(129, 98);
            this.txtSenderPassword.Name = "txtSenderPassword";
            this.txtSenderPassword.PasswordChar = '●';
            this.txtSenderPassword.Size = new System.Drawing.Size(169, 20);
            this.txtSenderPassword.TabIndex = 4;
            this.txtSenderPassword.TextChanged += new System.EventHandler(this.optionsTextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "*Mot de passe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "*Adresse Email:";
            // 
            // txtSenderNames
            // 
            this.txtSenderNames.Location = new System.Drawing.Point(129, 42);
            this.txtSenderNames.Name = "txtSenderNames";
            this.txtSenderNames.Size = new System.Drawing.Size(169, 20);
            this.txtSenderNames.TabIndex = 2;
            this.txtSenderNames.TextChanged += new System.EventHandler(this.optionsTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "*Le nom de l\'éxpediteur:";
            // 
            // cbxEmailType
            // 
            this.cbxEmailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmailType.FormattingEnabled = true;
            this.cbxEmailType.Items.AddRange(new object[] {
            "Gmail",
            "Yahoo"});
            this.cbxEmailType.Location = new System.Drawing.Point(129, 13);
            this.cbxEmailType.Name = "cbxEmailType";
            this.cbxEmailType.Size = new System.Drawing.Size(169, 21);
            this.cbxEmailType.TabIndex = 1;
            this.cbxEmailType.SelectedIndexChanged += new System.EventHandler(this.cbxEmailTypeIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Type d\'email:";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 2000;
            this.timerStatus.Tick += new System.EventHandler(this.timerDoneTick);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 512);
            this.Controls.Add(this.tabManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.tabManager.ResumeLayout(false);
            this.tabPageMeetings.ResumeLayout(false);
            this.tabPageMeetings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageStatistics.ResumeLayout(false);
            this.grpObservation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            this.grpSelection.ResumeLayout(false);
            this.panelPeriod.ResumeLayout(false);
            this.panelPeriod.PerformLayout();
            this.panelMeetings.ResumeLayout(false);
            this.panelMeetings.PerformLayout();
            this.panelSex.ResumeLayout(false);
            this.panelSex.PerformLayout();
            this.panelMembers.ResumeLayout(false);
            this.panelMembers.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManager;
        private System.Windows.Forms.TabPage tabPageMeetings;
        private System.Windows.Forms.Button btnDeleteMeeting;
        private System.Windows.Forms.Button btnSaveMeeting;
        private System.Windows.Forms.Button btnCreateMeeting;
        private System.Windows.Forms.DateTimePicker dateMeetingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMeetings;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPresenceCount;
        private System.Windows.Forms.Label lblMeetingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchToCheck;
        private System.Windows.Forms.CheckedListBox clbxAttendees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox grpObservation;
        private System.Windows.Forms.GroupBox grpSelection;
        private System.Windows.Forms.Panel panelSex;
        private System.Windows.Forms.CheckBox cbxAllSex;
        private System.Windows.Forms.CheckedListBox clbxSex;
        private System.Windows.Forms.Panel panelMembers;
        private System.Windows.Forms.CheckBox cbxAllMembers;
        private System.Windows.Forms.CheckedListBox clbxMembers;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.RadioButton rdbByPerson;
        private System.Windows.Forms.RadioButton rdbBySex;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMeetingsCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPeriod;
        private System.Windows.Forms.Panel panelMeetings;
        private System.Windows.Forms.CheckedListBox clbxMeetings;
        private System.Windows.Forms.CheckBox cbxAllMeetings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.RadioButton rdbMeetings;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.RadioButton rdbPeriod;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.TextBox txtSenderPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSenderNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEmailType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelOptions;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.Label lblEmailOptionsStatus;
        private System.Windows.Forms.Label lblEmailOptionsSavedStatus;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
    }
}