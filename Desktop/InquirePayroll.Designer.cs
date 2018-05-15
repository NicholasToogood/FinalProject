namespace Desktop
{
    partial class InquirePayroll
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
            this.grpBoxSearchEmp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoSearchByID = new System.Windows.Forms.RadioButton();
            this.rdoSearchByName = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.btnInquirePayroll = new System.Windows.Forms.Button();
            this.grpBoxInquirePayroll = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPaystubs = new System.Windows.Forms.DataGridView();
            this.btnSearchPaystubs = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReturnToSearch = new System.Windows.Forms.Button();
            this.grpBoxSearchEmp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpBoxInquirePayroll.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaystubs)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSearchEmp
            // 
            this.grpBoxSearchEmp.Controls.Add(this.groupBox1);
            this.grpBoxSearchEmp.Controls.Add(this.groupBox2);
            this.grpBoxSearchEmp.Controls.Add(this.groupBox4);
            this.grpBoxSearchEmp.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSearchEmp.Name = "grpBoxSearchEmp";
            this.grpBoxSearchEmp.Size = new System.Drawing.Size(506, 440);
            this.grpBoxSearchEmp.TabIndex = 16;
            this.grpBoxSearchEmp.TabStop = false;
            this.grpBoxSearchEmp.Text = "Employee Search";
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
            this.groupBox4.Controls.Add(this.btnInquirePayroll);
            this.groupBox4.Location = new System.Drawing.Point(205, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 319);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Information";
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
            // btnInquirePayroll
            // 
            this.btnInquirePayroll.Location = new System.Drawing.Point(7, 241);
            this.btnInquirePayroll.Name = "btnInquirePayroll";
            this.btnInquirePayroll.Size = new System.Drawing.Size(119, 31);
            this.btnInquirePayroll.TabIndex = 17;
            this.btnInquirePayroll.Text = "&Inquire Payroll";
            this.btnInquirePayroll.UseVisualStyleBackColor = true;
            this.btnInquirePayroll.Click += new System.EventHandler(this.btnInquirePayroll_Click);
            // 
            // grpBoxInquirePayroll
            // 
            this.grpBoxInquirePayroll.Controls.Add(this.groupBox3);
            this.grpBoxInquirePayroll.Controls.Add(this.btnReturnToSearch);
            this.grpBoxInquirePayroll.Location = new System.Drawing.Point(12, 12);
            this.grpBoxInquirePayroll.Name = "grpBoxInquirePayroll";
            this.grpBoxInquirePayroll.Size = new System.Drawing.Size(618, 345);
            this.grpBoxInquirePayroll.TabIndex = 17;
            this.grpBoxInquirePayroll.TabStop = false;
            this.grpBoxInquirePayroll.Text = "Inquire Payroll";
            this.grpBoxInquirePayroll.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewPaystubs);
            this.groupBox3.Controls.Add(this.btnSearchPaystubs);
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(26, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 254);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridViewPaystubs
            // 
            this.dataGridViewPaystubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaystubs.Location = new System.Drawing.Point(15, 83);
            this.dataGridViewPaystubs.Name = "dataGridViewPaystubs";
            this.dataGridViewPaystubs.Size = new System.Drawing.Size(459, 148);
            this.dataGridViewPaystubs.TabIndex = 5;
            // 
            // btnSearchPaystubs
            // 
            this.btnSearchPaystubs.Location = new System.Drawing.Point(291, 26);
            this.btnSearchPaystubs.Name = "btnSearchPaystubs";
            this.btnSearchPaystubs.Size = new System.Drawing.Size(75, 34);
            this.btnSearchPaystubs.TabIndex = 4;
            this.btnSearchPaystubs.Text = "&Search";
            this.btnSearchPaystubs.UseVisualStyleBackColor = true;
            this.btnSearchPaystubs.Click += new System.EventHandler(this.btnSearchPaystubs_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(76, 47);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(134, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(76, 21);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(134, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Date:";
            // 
            // btnReturnToSearch
            // 
            this.btnReturnToSearch.Location = new System.Drawing.Point(28, 24);
            this.btnReturnToSearch.Name = "btnReturnToSearch";
            this.btnReturnToSearch.Size = new System.Drawing.Size(119, 31);
            this.btnReturnToSearch.TabIndex = 19;
            this.btnReturnToSearch.Text = "&Return To Search";
            this.btnReturnToSearch.UseVisualStyleBackColor = true;
            this.btnReturnToSearch.Click += new System.EventHandler(this.btnReturnToSearch_Click);
            // 
            // InquirePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.grpBoxInquirePayroll);
            this.Controls.Add(this.grpBoxSearchEmp);
            this.Name = "InquirePayroll";
            this.Text = "InquirePayroll";
            this.Load += new System.EventHandler(this.InquirePayroll_Load);
            this.grpBoxSearchEmp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpBoxInquirePayroll.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaystubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSearchEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoSearchByID;
        private System.Windows.Forms.RadioButton rdoSearchByName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPayrollEmailNotification;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtWorkPhoneNumber;
        private System.Windows.Forms.TextBox txtCellPhoneNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInquirePayroll;
        private System.Windows.Forms.GroupBox grpBoxInquirePayroll;
        private System.Windows.Forms.Button btnReturnToSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewPaystubs;
        private System.Windows.Forms.Button btnSearchPaystubs;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label6;
    }
}