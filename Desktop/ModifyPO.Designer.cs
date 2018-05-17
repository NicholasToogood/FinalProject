namespace Desktop
{
    partial class ModifyPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPO));
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderDates = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubNum = new System.Windows.Forms.Label();
            this.lblTaxNum = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(9, 7);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(113, 20);
            this.lblOrderNumber.TabIndex = 33;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(134, 11);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(108, 20);
            this.txtOrderNumber.TabIndex = 34;
            // 
            // lblOrderDates
            // 
            this.lblOrderDates.AutoSize = true;
            this.lblOrderDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDates.Location = new System.Drawing.Point(23, 45);
            this.lblOrderDates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDates.Name = "lblOrderDates";
            this.lblOrderDates.Size = new System.Drawing.Size(100, 20);
            this.lblOrderDates.TabIndex = 35;
            this.lblOrderDates.Text = "Order Dates:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(134, 46);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(108, 20);
            this.dtpStart.TabIndex = 36;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(292, 47);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(108, 20);
            this.dtpEnd.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "-";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(155, 67);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 39;
            this.lblStartDate.Text = "(Start Date)";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(316, 67);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 40;
            this.lblEndDate.Text = "(End Date)";
            // 
            // btnSearchId
            // 
            this.btnSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchId.Location = new System.Drawing.Point(574, 4);
            this.btnSearchId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(124, 28);
            this.btnSearchId.TabIndex = 41;
            this.btnSearchId.Text = "Search By Id";
            this.btnSearchId.UseVisualStyleBackColor = true;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(574, 37);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(124, 28);
            this.btnSearchDate.TabIndex = 42;
            this.btnSearchDate.Text = "Search By Date";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.Enabled = false;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(13, 115);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(168, 95);
            this.lstOrders.TabIndex = 44;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(13, 218);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(689, 220);
            this.dgvItems.TabIndex = 45;
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            this.dgvItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItems_CellMouseClick);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(300, 115);
            this.lblSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(77, 20);
            this.lblSub.TabIndex = 46;
            this.lblSub.Text = "Sub total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(332, 135);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 20);
            this.lblTax.TabIndex = 47;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(325, 155);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubNum
            // 
            this.lblSubNum.AutoSize = true;
            this.lblSubNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNum.Location = new System.Drawing.Point(389, 115);
            this.lblSubNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubNum.Name = "lblSubNum";
            this.lblSubNum.Size = new System.Drawing.Size(53, 20);
            this.lblSubNum.TabIndex = 49;
            this.lblSubNum.Text = "$ 0.00";
            // 
            // lblTaxNum
            // 
            this.lblTaxNum.AutoSize = true;
            this.lblTaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxNum.Location = new System.Drawing.Point(389, 135);
            this.lblTaxNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxNum.Name = "lblTaxNum";
            this.lblTaxNum.Size = new System.Drawing.Size(53, 20);
            this.lblTaxNum.TabIndex = 50;
            this.lblTaxNum.Text = "$ 0.00";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(389, 155);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(53, 20);
            this.lblTotalNum.TabIndex = 51;
            this.lblTotalNum.Text = "$ 0.00";
            // 
            // ModifyPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 448);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblTaxNum);
            this.Controls.Add(this.lblSubNum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearchId);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblOrderDates);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txtOrderNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyPO";
            this.Text = "Modify Purchase Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblOrderDates;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubNum;
        private System.Windows.Forms.Label lblTaxNum;
        private System.Windows.Forms.Label lblTotalNum;
    }
}