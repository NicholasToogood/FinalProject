namespace Desktop
{
    partial class AddSickDayHR
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
            this.rdoSearchByName = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoSearchByID = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSickDays = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPayrollEmailNotification = new System.Windows.Forms.CheckBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtWorkPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCellPhoneNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxSearchEmp = new System.Windows.Forms.GroupBox();
            this.grpBoxRecordSickDays = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblSickDayEndDate = new System.Windows.Forms.Label();
            this.dtpSickDayEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkRangeOfSickDates = new System.Windows.Forms.CheckBox();
            this.btnAddSickDay = new System.Windows.Forms.Button();
            this.btnClearSickDay = new System.Windows.Forms.Button();
            this.txtSickDayDescription = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cmbLenthOfDay = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpSickDayDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotalSickDays = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.dataGridviewSickDays = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpBoxSearchEmp.SuspendLayout();
            this.grpBoxRecordSickDays.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewSickDays)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoSearchByName
            // 
            this.rdoSearchByName.AutoSize = true;
            this.rdoSearchByName.Location = new System.Drawing.Point(6, 43);
            this.rdoSearchByName.Name = "rdoSearchByName";
            this.rdoSearchByName.Size = new System.Drawing.Size(105, 17);
            this.rdoSearchByName.TabIndex = 0;
            this.rdoSearchByName.TabStop = true;
            this.rdoSearchByName.Text = "Search By Name";
            this.rdoSearchByName.UseVisualStyleBackColor = true;
            this.rdoSearchByName.CheckedChanged += new System.EventHandler(this.rdoSearchByName_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.rdoSearchByID);
            this.groupBox1.Controls.Add(this.rdoSearchByName);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(147, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Enter Emp ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // rdoSearchByID
            // 
            this.rdoSearchByID.AutoSize = true;
            this.rdoSearchByID.Location = new System.Drawing.Point(6, 19);
            this.rdoSearchByID.Name = "rdoSearchByID";
            this.rdoSearchByID.Size = new System.Drawing.Size(88, 17);
            this.rdoSearchByID.TabIndex = 1;
            this.rdoSearchByID.TabStop = true;
            this.rdoSearchByID.Text = "Search By ID";
            this.rdoSearchByID.UseVisualStyleBackColor = true;
            this.rdoSearchByID.CheckedChanged += new System.EventHandler(this.rdoSearchByID_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxResults);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(18, 28);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(127, 121);
            this.listBoxResults.TabIndex = 0;
            this.listBoxResults.SelectedIndexChanged += new System.EventHandler(this.listBoxResults_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSickDays);
            this.groupBox4.Controls.Add(this.txtLastName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.chkPayrollEmailNotification);
            this.groupBox4.Controls.Add(this.txtEmailAddress);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtWorkPhoneNumber);
            this.groupBox4.Controls.Add(this.txtCellPhoneNumber);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtStreetAddress);
            this.groupBox4.Controls.Add(this.txtMiddleInitial);
            this.groupBox4.Controls.Add(this.txtFirstName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(205, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 319);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Information";
            // 
            // btnSickDays
            // 
            this.btnSickDays.Location = new System.Drawing.Point(19, 239);
            this.btnSickDays.Name = "btnSickDays";
            this.btnSickDays.Size = new System.Drawing.Size(119, 31);
            this.btnSickDays.TabIndex = 19;
            this.btnSickDays.Text = "&View Sick Days";
            this.btnSickDays.UseVisualStyleBackColor = true;
            this.btnSickDays.Click += new System.EventHandler(this.btnSickDays_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(139, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Payroll Email Notification";
            // 
            // chkPayrollEmailNotification
            // 
            this.chkPayrollEmailNotification.AutoSize = true;
            this.chkPayrollEmailNotification.Enabled = false;
            this.chkPayrollEmailNotification.Location = new System.Drawing.Point(130, 215);
            this.chkPayrollEmailNotification.Name = "chkPayrollEmailNotification";
            this.chkPayrollEmailNotification.Size = new System.Drawing.Size(15, 14);
            this.chkPayrollEmailNotification.TabIndex = 14;
            this.chkPayrollEmailNotification.UseVisualStyleBackColor = true;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(132, 185);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(139, 20);
            this.txtEmailAddress.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Email Address:";
            // 
            // txtWorkPhoneNumber
            // 
            this.txtWorkPhoneNumber.Location = new System.Drawing.Point(132, 133);
            this.txtWorkPhoneNumber.Name = "txtWorkPhoneNumber";
            this.txtWorkPhoneNumber.ReadOnly = true;
            this.txtWorkPhoneNumber.Size = new System.Drawing.Size(139, 20);
            this.txtWorkPhoneNumber.TabIndex = 11;
            // 
            // txtCellPhoneNumber
            // 
            this.txtCellPhoneNumber.Location = new System.Drawing.Point(132, 159);
            this.txtCellPhoneNumber.Name = "txtCellPhoneNumber";
            this.txtCellPhoneNumber.ReadOnly = true;
            this.txtCellPhoneNumber.Size = new System.Drawing.Size(139, 20);
            this.txtCellPhoneNumber.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Work Phone Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Cell Phone Number:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(132, 107);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(139, 20);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(132, 54);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.ReadOnly = true;
            this.txtMiddleInitial.Size = new System.Drawing.Size(30, 20);
            this.txtMiddleInitial.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(132, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Street Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Initial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // grpBoxSearchEmp
            // 
            this.grpBoxSearchEmp.Controls.Add(this.groupBox1);
            this.grpBoxSearchEmp.Controls.Add(this.groupBox2);
            this.grpBoxSearchEmp.Controls.Add(this.groupBox4);
            this.grpBoxSearchEmp.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSearchEmp.Name = "grpBoxSearchEmp";
            this.grpBoxSearchEmp.Size = new System.Drawing.Size(506, 440);
            this.grpBoxSearchEmp.TabIndex = 14;
            this.grpBoxSearchEmp.TabStop = false;
            this.grpBoxSearchEmp.Text = "Employee Search";
            // 
            // grpBoxRecordSickDays
            // 
            this.grpBoxRecordSickDays.Controls.Add(this.groupBox7);
            this.grpBoxRecordSickDays.Controls.Add(this.groupBox6);
            this.grpBoxRecordSickDays.Controls.Add(this.button2);
            this.grpBoxRecordSickDays.Location = new System.Drawing.Point(12, 8);
            this.grpBoxRecordSickDays.Name = "grpBoxRecordSickDays";
            this.grpBoxRecordSickDays.Size = new System.Drawing.Size(555, 462);
            this.grpBoxRecordSickDays.TabIndex = 20;
            this.grpBoxRecordSickDays.TabStop = false;
            this.grpBoxRecordSickDays.Text = "Record Sick Days";
            this.grpBoxRecordSickDays.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblSickDayEndDate);
            this.groupBox7.Controls.Add(this.dtpSickDayEndDate);
            this.groupBox7.Controls.Add(this.chkRangeOfSickDates);
            this.groupBox7.Controls.Add(this.btnAddSickDay);
            this.groupBox7.Controls.Add(this.btnClearSickDay);
            this.groupBox7.Controls.Add(this.txtSickDayDescription);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.cmbLenthOfDay);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.dtpSickDayDate);
            this.groupBox7.Location = new System.Drawing.Point(19, 250);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(458, 188);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Add New Sick Day";
            // 
            // lblSickDayEndDate
            // 
            this.lblSickDayEndDate.AutoSize = true;
            this.lblSickDayEndDate.Location = new System.Drawing.Point(6, 51);
            this.lblSickDayEndDate.Name = "lblSickDayEndDate";
            this.lblSickDayEndDate.Size = new System.Drawing.Size(101, 13);
            this.lblSickDayEndDate.TabIndex = 10;
            this.lblSickDayEndDate.Text = "Sick Day End Date:";
            this.lblSickDayEndDate.Visible = false;
            // 
            // dtpSickDayEndDate
            // 
            this.dtpSickDayEndDate.Location = new System.Drawing.Point(116, 48);
            this.dtpSickDayEndDate.Name = "dtpSickDayEndDate";
            this.dtpSickDayEndDate.Size = new System.Drawing.Size(142, 20);
            this.dtpSickDayEndDate.TabIndex = 9;
            this.dtpSickDayEndDate.Visible = false;
            // 
            // chkRangeOfSickDates
            // 
            this.chkRangeOfSickDates.AutoSize = true;
            this.chkRangeOfSickDates.Location = new System.Drawing.Point(318, 27);
            this.chkRangeOfSickDates.Name = "chkRangeOfSickDates";
            this.chkRangeOfSickDates.Size = new System.Drawing.Size(101, 17);
            this.chkRangeOfSickDates.TabIndex = 8;
            this.chkRangeOfSickDates.Text = "Range of Dates";
            this.chkRangeOfSickDates.UseVisualStyleBackColor = true;
            this.chkRangeOfSickDates.Click += new System.EventHandler(this.chkRangeOfSickDates_CheckedChanged);
            // 
            // btnAddSickDay
            // 
            this.btnAddSickDay.Location = new System.Drawing.Point(340, 146);
            this.btnAddSickDay.Name = "btnAddSickDay";
            this.btnAddSickDay.Size = new System.Drawing.Size(96, 28);
            this.btnAddSickDay.TabIndex = 7;
            this.btnAddSickDay.Text = "&Add Sick Day(s)";
            this.btnAddSickDay.UseVisualStyleBackColor = true;
            this.btnAddSickDay.Click += new System.EventHandler(this.btnAddSickDay_Click);
            // 
            // btnClearSickDay
            // 
            this.btnClearSickDay.Location = new System.Drawing.Point(340, 112);
            this.btnClearSickDay.Name = "btnClearSickDay";
            this.btnClearSickDay.Size = new System.Drawing.Size(96, 28);
            this.btnClearSickDay.TabIndex = 6;
            this.btnClearSickDay.Text = "&Clear";
            this.btnClearSickDay.UseVisualStyleBackColor = true;
            this.btnClearSickDay.Click += new System.EventHandler(this.btnClearSickDay_Click);
            // 
            // txtSickDayDescription
            // 
            this.txtSickDayDescription.Location = new System.Drawing.Point(116, 103);
            this.txtSickDayDescription.Multiline = true;
            this.txtSickDayDescription.Name = "txtSickDayDescription";
            this.txtSickDayDescription.Size = new System.Drawing.Size(208, 69);
            this.txtSickDayDescription.TabIndex = 5;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(45, 107);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Description:";
            // 
            // cmbLenthOfDay
            // 
            this.cmbLenthOfDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLenthOfDay.FormattingEnabled = true;
            this.cmbLenthOfDay.Location = new System.Drawing.Point(116, 76);
            this.cmbLenthOfDay.Name = "cmbLenthOfDay";
            this.cmbLenthOfDay.Size = new System.Drawing.Size(142, 21);
            this.cmbLenthOfDay.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(28, 79);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Full or Half Day:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "Sick Day Date:";
            // 
            // dtpSickDayDate
            // 
            this.dtpSickDayDate.Location = new System.Drawing.Point(116, 22);
            this.dtpSickDayDate.Name = "dtpSickDayDate";
            this.dtpSickDayDate.Size = new System.Drawing.Size(142, 20);
            this.dtpSickDayDate.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTotalSickDays);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Controls.Add(this.dataGridviewSickDays);
            this.groupBox6.Location = new System.Drawing.Point(18, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(458, 178);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Past Sick Days";
            // 
            // txtTotalSickDays
            // 
            this.txtTotalSickDays.Location = new System.Drawing.Point(103, 147);
            this.txtTotalSickDays.Name = "txtTotalSickDays";
            this.txtTotalSickDays.ReadOnly = true;
            this.txtTotalSickDays.Size = new System.Drawing.Size(59, 20);
            this.txtTotalSickDays.TabIndex = 9;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(14, 150);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(85, 13);
            this.label53.TabIndex = 8;
            this.label53.Text = "Total Sick Days:";
            // 
            // dataGridviewSickDays
            // 
            this.dataGridviewSickDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewSickDays.Location = new System.Drawing.Point(12, 21);
            this.dataGridviewSickDays.Name = "dataGridviewSickDays";
            this.dataGridviewSickDays.Size = new System.Drawing.Size(431, 116);
            this.dataGridviewSickDays.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "&Return To Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReturnToSearch_Click);
            // 
            // AddSickDayHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(759, 558);
            this.Controls.Add(this.grpBoxRecordSickDays);
            this.Controls.Add(this.grpBoxSearchEmp);
            this.Name = "AddSickDayHR";
            this.Text = "Add Sick Days";
            this.Load += new System.EventHandler(this.SearchRetrieveEmployeeHR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpBoxSearchEmp.ResumeLayout(false);
            this.grpBoxRecordSickDays.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewSickDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSearchByName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSearchByID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkPhoneNumber;
        private System.Windows.Forms.TextBox txtCellPhoneNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkPayrollEmailNotification;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBoxSearchEmp;
        private System.Windows.Forms.Button btnSickDays;
        private System.Windows.Forms.GroupBox grpBoxRecordSickDays;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnAddSickDay;
        private System.Windows.Forms.Button btnClearSickDay;
        private System.Windows.Forms.TextBox txtSickDayDescription;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cmbLenthOfDay;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpSickDayDate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridviewSickDays;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtTotalSickDays;
        private System.Windows.Forms.Label lblSickDayEndDate;
        private System.Windows.Forms.DateTimePicker dtpSickDayEndDate;
        private System.Windows.Forms.CheckBox chkRangeOfSickDates;
    }
}