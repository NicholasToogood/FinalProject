namespace Desktop
{
    partial class ProcessPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessPO));
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderStatusLabel = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.grpSrcType = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoClosed = new System.Windows.Forms.RadioButton();
            this.rdoPending = new System.Windows.Forms.RadioButton();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDates = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.grpTop.SuspendLayout();
            this.grpSrcType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.Enabled = false;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(9, 10);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(91, 212);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // btnDeny
            // 
            this.btnDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.Location = new System.Drawing.Point(440, 404);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(124, 28);
            this.btnDeny.TabIndex = 52;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(156, 404);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(124, 28);
            this.btnApprove.TabIndex = 51;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblOrderNumberLabel
            // 
            this.lblOrderNumberLabel.AutoSize = true;
            this.lblOrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumberLabel.Location = new System.Drawing.Point(43, 26);
            this.lblOrderNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumberLabel.Name = "lblOrderNumberLabel";
            this.lblOrderNumberLabel.Size = new System.Drawing.Size(113, 20);
            this.lblOrderNumberLabel.TabIndex = 43;
            this.lblOrderNumberLabel.Text = "Order Number:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(154, 26);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(81, 20);
            this.lblOrderNumber.TabIndex = 53;
            this.lblOrderNumber.Text = "00000000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(154, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "Name";
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.Location = new System.Drawing.Point(28, 54);
            this.lblNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(129, 20);
            this.lblNameLabel.TabIndex = 54;
            this.lblNameLabel.Text = "Employee Name:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(345, 54);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(285, 54);
            this.lblTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(48, 20);
            this.lblTotalLabel.TabIndex = 58;
            this.lblTotalLabel.Text = "Total:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(343, 26);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 57;
            this.lblDate.Text = "Date";
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLabel.Location = new System.Drawing.Point(287, 26);
            this.lblDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(48, 20);
            this.lblDateLabel.TabIndex = 56;
            this.lblDateLabel.Text = "Date:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(345, 84);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(100, 20);
            this.lblOrderStatus.TabIndex = 61;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // lblOrderStatusLabel
            // 
            this.lblOrderStatusLabel.AutoSize = true;
            this.lblOrderStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusLabel.Location = new System.Drawing.Point(235, 84);
            this.lblOrderStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderStatusLabel.Name = "lblOrderStatusLabel";
            this.lblOrderStatusLabel.Size = new System.Drawing.Size(104, 20);
            this.lblOrderStatusLabel.TabIndex = 60;
            this.lblOrderStatusLabel.Text = "Order Status:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(9, 234);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(682, 165);
            this.dgvItems.TabIndex = 62;
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.lblOrderNumberLabel);
            this.grpTop.Controls.Add(this.lblOrderNumber);
            this.grpTop.Controls.Add(this.lblOrderStatus);
            this.grpTop.Controls.Add(this.lblNameLabel);
            this.grpTop.Controls.Add(this.lblOrderStatusLabel);
            this.grpTop.Controls.Add(this.lblName);
            this.grpTop.Controls.Add(this.lblTotal);
            this.grpTop.Controls.Add(this.lblDateLabel);
            this.grpTop.Controls.Add(this.lblTotalLabel);
            this.grpTop.Controls.Add(this.lblDate);
            this.grpTop.Location = new System.Drawing.Point(115, 110);
            this.grpTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTop.Name = "grpTop";
            this.grpTop.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTop.Size = new System.Drawing.Size(449, 110);
            this.grpTop.TabIndex = 63;
            this.grpTop.TabStop = false;
            this.grpTop.Text = "Order Information";
            this.grpTop.Visible = false;
            // 
            // grpSrcType
            // 
            this.grpSrcType.Controls.Add(this.rdoAll);
            this.grpSrcType.Controls.Add(this.rdoClosed);
            this.grpSrcType.Controls.Add(this.rdoPending);
            this.grpSrcType.Location = new System.Drawing.Point(115, 11);
            this.grpSrcType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSrcType.Name = "grpSrcType";
            this.grpSrcType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSrcType.Size = new System.Drawing.Size(104, 95);
            this.grpSrcType.TabIndex = 64;
            this.grpSrcType.TabStop = false;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(22, 63);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(70, 17);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.Text = "All Orders";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoClosed
            // 
            this.rdoClosed.AutoSize = true;
            this.rdoClosed.Location = new System.Drawing.Point(22, 40);
            this.rdoClosed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoClosed.Name = "rdoClosed";
            this.rdoClosed.Size = new System.Drawing.Size(57, 17);
            this.rdoClosed.TabIndex = 1;
            this.rdoClosed.Text = "Closed";
            this.rdoClosed.UseVisualStyleBackColor = true;
            this.rdoClosed.CheckedChanged += new System.EventHandler(this.rdoClosed_CheckedChanged);
            // 
            // rdoPending
            // 
            this.rdoPending.AutoSize = true;
            this.rdoPending.Checked = true;
            this.rdoPending.Location = new System.Drawing.Point(22, 17);
            this.rdoPending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPending.Name = "rdoPending";
            this.rdoPending.Size = new System.Drawing.Size(64, 17);
            this.rdoPending.TabIndex = 0;
            this.rdoPending.TabStop = true;
            this.rdoPending.Text = "Pending";
            this.rdoPending.UseVisualStyleBackColor = true;
            this.rdoPending.CheckedChanged += new System.EventHandler(this.rdoPending_CheckedChanged);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(568, 178);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(124, 43);
            this.btnSearchDate.TabIndex = 74;
            this.btnSearchDate.Text = "Search By Date";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(568, 124);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(124, 46);
            this.btnSearchName.TabIndex = 73;
            this.btnSearchName.Text = "Search By Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(535, 84);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 72;
            this.lblEndDate.Text = "(End Date)";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(374, 83);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 71;
            this.lblStartDate.Text = "(Start Date)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "-";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(511, 63);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(108, 20);
            this.dtpEnd.TabIndex = 69;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(353, 63);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(108, 20);
            this.dtpStart.TabIndex = 68;
            // 
            // lblOrderDates
            // 
            this.lblOrderDates.AutoSize = true;
            this.lblOrderDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDates.Location = new System.Drawing.Point(250, 61);
            this.lblOrderDates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDates.Name = "lblOrderDates";
            this.lblOrderDates.Size = new System.Drawing.Size(100, 20);
            this.lblOrderDates.TabIndex = 67;
            this.lblOrderDates.Text = "Order Dates:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(224, 24);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(129, 20);
            this.lblEmpName.TabIndex = 65;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(353, 27);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(108, 20);
            this.txtEmpName.TabIndex = 66;
            // 
            // ProcessPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 480);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblOrderDates);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.grpSrcType);
            this.Controls.Add(this.grpTop);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lstOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProcessPO";
            this.Text = "ProcessPO";
            this.Load += new System.EventHandler(this.ProcessPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.grpTop.ResumeLayout(false);
            this.grpTop.PerformLayout();
            this.grpSrcType.ResumeLayout(false);
            this.grpSrcType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblOrderNumberLabel;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrderStatusLabel;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox grpTop;
        private System.Windows.Forms.GroupBox grpSrcType;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoClosed;
        private System.Windows.Forms.RadioButton rdoPending;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblOrderDates;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
    }
}