namespace Desktop
{
    partial class CreatePO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePO));
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblJustification = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblSuper = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubNum = new System.Windows.Forms.Label();
            this.lblTaxNum = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.lblOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblEnterOrder = new System.Windows.Forms.Label();
            this.txtEnterOrder = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.grpTotal.SuspendLayout();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(164, 295);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 37);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtJustification
            // 
            this.txtJustification.Location = new System.Drawing.Point(111, 214);
            this.txtJustification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(246, 67);
            this.txtJustification.TabIndex = 37;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(111, 184);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(246, 20);
            this.txtLocation.TabIndex = 36;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(111, 154);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(246, 20);
            this.txtPrice.TabIndex = 35;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(111, 123);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(246, 20);
            this.txtQty.TabIndex = 34;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(111, 52);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(246, 62);
            this.txtDesc.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 32;
            // 
            // lblJustification
            // 
            this.lblJustification.AutoSize = true;
            this.lblJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustification.Location = new System.Drawing.Point(3, 211);
            this.lblJustification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJustification.Name = "lblJustification";
            this.lblJustification.Size = new System.Drawing.Size(97, 20);
            this.lblJustification.TabIndex = 31;
            this.lblJustification.Text = "Justification:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(24, 180);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 20);
            this.lblLocation.TabIndex = 30;
            this.lblLocation.Text = "Location:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(46, 151);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(24, 119);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 20);
            this.lblQty.TabIndex = 28;
            this.lblQty.Text = "Quantity:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(6, 49);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(93, 20);
            this.lblDesc.TabIndex = 27;
            this.lblDesc.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 20);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Item Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 31);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Create Purchase Order";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(17, 48);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(554, 7);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(110, 20);
            this.lblEmpName.TabIndex = 41;
            this.lblEmpName.Text = "Mike Donovan";
            this.lblEmpName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(495, 28);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(175, 20);
            this.lblDept.TabIndex = 42;
            this.lblDept.Text = "Information Technology";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSuper
            // 
            this.lblSuper.AutoSize = true;
            this.lblSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuper.Location = new System.Drawing.Point(578, 48);
            this.lblSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuper.Name = "lblSuper";
            this.lblSuper.Size = new System.Drawing.Size(82, 20);
            this.lblSuper.TabIndex = 43;
            this.lblSuper.Text = "John Wick";
            this.lblSuper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(12, 25);
            this.lblSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(81, 20);
            this.lblSub.TabIndex = 44;
            this.lblSub.Text = "Sub Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(50, 56);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 20);
            this.lblTax.TabIndex = 45;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(43, 86);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubNum
            // 
            this.lblSubNum.AutoSize = true;
            this.lblSubNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNum.Location = new System.Drawing.Point(103, 24);
            this.lblSubNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubNum.Name = "lblSubNum";
            this.lblSubNum.Size = new System.Drawing.Size(49, 20);
            this.lblSubNum.TabIndex = 47;
            this.lblSubNum.Text = "$0.00";
            // 
            // lblTaxNum
            // 
            this.lblTaxNum.AutoSize = true;
            this.lblTaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxNum.Location = new System.Drawing.Point(103, 56);
            this.lblTaxNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxNum.Name = "lblTaxNum";
            this.lblTaxNum.Size = new System.Drawing.Size(49, 20);
            this.lblTaxNum.TabIndex = 48;
            this.lblTaxNum.Text = "$0.00";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(103, 86);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(49, 20);
            this.lblTotalNum.TabIndex = 49;
            this.lblTotalNum.Text = "$0.00";
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblSub);
            this.grpTotal.Controls.Add(this.lblTotalNum);
            this.grpTotal.Controls.Add(this.lblTax);
            this.grpTotal.Controls.Add(this.lblTaxNum);
            this.grpTotal.Controls.Add(this.lblTotal);
            this.grpTotal.Controls.Add(this.lblSubNum);
            this.grpTotal.Location = new System.Drawing.Point(445, 300);
            this.grpTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTotal.Size = new System.Drawing.Size(215, 128);
            this.grpTotal.TabIndex = 50;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total";
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.txtDesc);
            this.grpItem.Controls.Add(this.lblName);
            this.grpItem.Controls.Add(this.lblDesc);
            this.grpItem.Controls.Add(this.lblQty);
            this.grpItem.Controls.Add(this.lblPrice);
            this.grpItem.Controls.Add(this.lblLocation);
            this.grpItem.Controls.Add(this.lblJustification);
            this.grpItem.Controls.Add(this.btnCreate);
            this.grpItem.Controls.Add(this.txtName);
            this.grpItem.Controls.Add(this.txtJustification);
            this.grpItem.Controls.Add(this.txtQty);
            this.grpItem.Controls.Add(this.txtLocation);
            this.grpItem.Controls.Add(this.txtPrice);
            this.grpItem.Location = new System.Drawing.Point(21, 79);
            this.grpItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpItem.Size = new System.Drawing.Size(384, 349);
            this.grpItem.TabIndex = 51;
            this.grpItem.TabStop = false;
            // 
            // lblOrderNumberLabel
            // 
            this.lblOrderNumberLabel.AutoSize = true;
            this.lblOrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumberLabel.Location = new System.Drawing.Point(441, 79);
            this.lblOrderNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumberLabel.Name = "lblOrderNumberLabel";
            this.lblOrderNumberLabel.Size = new System.Drawing.Size(113, 20);
            this.lblOrderNumberLabel.TabIndex = 50;
            this.lblOrderNumberLabel.Text = "Order Number:";
            this.lblOrderNumberLabel.Visible = false;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(564, 79);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(18, 20);
            this.lblOrderNumber.TabIndex = 51;
            this.lblOrderNumber.Text = "0";
            this.lblOrderNumber.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(445, 249);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(103, 43);
            this.btnAddToOrder.TabIndex = 39;
            this.btnAddToOrder.Text = "Add To Existing Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblEnterOrder
            // 
            this.lblEnterOrder.AutoSize = true;
            this.lblEnterOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterOrder.Location = new System.Drawing.Point(441, 214);
            this.lblEnterOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterOrder.Name = "lblEnterOrder";
            this.lblEnterOrder.Size = new System.Drawing.Size(113, 20);
            this.lblEnterOrder.TabIndex = 52;
            this.lblEnterOrder.Text = "Order Number:";
            this.lblEnterOrder.Visible = false;
            // 
            // txtEnterOrder
            // 
            this.txtEnterOrder.Location = new System.Drawing.Point(568, 217);
            this.txtEnterOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnterOrder.Name = "txtEnterOrder";
            this.txtEnterOrder.Size = new System.Drawing.Size(93, 20);
            this.txtEnterOrder.TabIndex = 39;
            this.txtEnterOrder.Visible = false;
            this.txtEnterOrder.TextChanged += new System.EventHandler(this.txtEnterOrder_TextChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(557, 249);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(103, 43);
            this.btnNewOrder.TabIndex = 53;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Visible = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(445, 102);
            this.lstItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(216, 108);
            this.lstItems.TabIndex = 54;
            // 
            // CreatePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 444);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.txtEnterOrder);
            this.Controls.Add(this.lblEnterOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblOrderNumberLabel);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.lblSuper);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePO";
            this.Text = "Create Purchase Order";
            this.Load += new System.EventHandler(this.CreatePO_Load);
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblJustification;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblSuper;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubNum;
        private System.Windows.Forms.Label lblTaxNum;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label lblOrderNumberLabel;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.TextBox txtEnterOrder;
        private System.Windows.Forms.Label lblEnterOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.ListBox lstItems;
    }
}

