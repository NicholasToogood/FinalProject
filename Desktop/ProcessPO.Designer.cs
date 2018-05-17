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
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(12, 12);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(120, 260);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // btnDeny
            // 
            this.btnDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.Location = new System.Drawing.Point(586, 497);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(166, 34);
            this.btnDeny.TabIndex = 52;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(208, 497);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(166, 34);
            this.btnApprove.TabIndex = 51;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblOrderNumberLabel
            // 
            this.lblOrderNumberLabel.AutoSize = true;
            this.lblOrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumberLabel.Location = new System.Drawing.Point(57, 32);
            this.lblOrderNumberLabel.Name = "lblOrderNumberLabel";
            this.lblOrderNumberLabel.Size = new System.Drawing.Size(142, 25);
            this.lblOrderNumberLabel.TabIndex = 43;
            this.lblOrderNumberLabel.Text = "Order Number:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(205, 32);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(100, 25);
            this.lblOrderNumber.TabIndex = 53;
            this.lblOrderNumber.Text = "00000000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(205, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "Name";
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.Location = new System.Drawing.Point(37, 67);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(162, 25);
            this.lblNameLabel.TabIndex = 54;
            this.lblNameLabel.Text = "Employee Name:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(460, 67);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(380, 67);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(62, 25);
            this.lblTotalLabel.TabIndex = 58;
            this.lblTotalLabel.Text = "Total:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(457, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 57;
            this.lblDate.Text = "Date";
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLabel.Location = new System.Drawing.Point(383, 32);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(59, 25);
            this.lblDateLabel.TabIndex = 56;
            this.lblDateLabel.Text = "Date:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(460, 103);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(123, 25);
            this.lblOrderStatus.TabIndex = 61;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // lblOrderStatusLabel
            // 
            this.lblOrderStatusLabel.AutoSize = true;
            this.lblOrderStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusLabel.Location = new System.Drawing.Point(313, 103);
            this.lblOrderStatusLabel.Name = "lblOrderStatusLabel";
            this.lblOrderStatusLabel.Size = new System.Drawing.Size(129, 25);
            this.lblOrderStatusLabel.TabIndex = 60;
            this.lblOrderStatusLabel.Text = "Order Status:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 288);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(910, 203);
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
            this.grpTop.Location = new System.Drawing.Point(153, 136);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(599, 136);
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
            this.grpSrcType.Location = new System.Drawing.Point(153, 13);
            this.grpSrcType.Name = "grpSrcType";
            this.grpSrcType.Size = new System.Drawing.Size(139, 117);
            this.grpSrcType.TabIndex = 64;
            this.grpSrcType.TabStop = false;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(30, 77);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(92, 21);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.Text = "All Orders";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoClosed
            // 
            this.rdoClosed.AutoSize = true;
            this.rdoClosed.Location = new System.Drawing.Point(30, 49);
            this.rdoClosed.Name = "rdoClosed";
            this.rdoClosed.Size = new System.Drawing.Size(72, 21);
            this.rdoClosed.TabIndex = 1;
            this.rdoClosed.Text = "Closed";
            this.rdoClosed.UseVisualStyleBackColor = true;
            this.rdoClosed.CheckedChanged += new System.EventHandler(this.rdoClosed_CheckedChanged);
            // 
            // rdoPending
            // 
            this.rdoPending.AutoSize = true;
            this.rdoPending.Checked = true;
            this.rdoPending.Location = new System.Drawing.Point(30, 21);
            this.rdoPending.Name = "rdoPending";
            this.rdoPending.Size = new System.Drawing.Size(81, 21);
            this.rdoPending.TabIndex = 0;
            this.rdoPending.TabStop = true;
            this.rdoPending.Text = "Pending";
            this.rdoPending.UseVisualStyleBackColor = true;
            this.rdoPending.CheckedChanged += new System.EventHandler(this.rdoPending_CheckedChanged);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(758, 219);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(166, 53);
            this.btnSearchDate.TabIndex = 74;
            this.btnSearchDate.Text = "Search By Date";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(758, 153);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(166, 56);
            this.btnSearchName.TabIndex = 73;
            this.btnSearchName.Text = "Search By Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(713, 103);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 17);
            this.lblEndDate.TabIndex = 72;
            this.lblEndDate.Text = "(End Date)";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(499, 102);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 17);
            this.lblStartDate.TabIndex = 71;
            this.lblStartDate.Text = "(Start Date)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "-";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(681, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(142, 22);
            this.dtpEnd.TabIndex = 69;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(471, 77);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(142, 22);
            this.dtpStart.TabIndex = 68;
            // 
            // lblOrderDates
            // 
            this.lblOrderDates.AutoSize = true;
            this.lblOrderDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDates.Location = new System.Drawing.Point(334, 75);
            this.lblOrderDates.Name = "lblOrderDates";
            this.lblOrderDates.Size = new System.Drawing.Size(124, 25);
            this.lblOrderDates.TabIndex = 67;
            this.lblOrderDates.Text = "Order Dates:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(298, 29);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(162, 25);
            this.lblEmpName.TabIndex = 65;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(471, 33);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(143, 22);
            this.txtEmpName.TabIndex = 66;
            // 
            // ProcessPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 591);
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