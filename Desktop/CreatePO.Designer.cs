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
            this.btnCreate.Location = new System.Drawing.Point(218, 363);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(165, 46);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtJustification
            // 
            this.txtJustification.Location = new System.Drawing.Point(148, 264);
            this.txtJustification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(327, 81);
            this.txtJustification.TabIndex = 37;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(148, 226);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(327, 22);
            this.txtLocation.TabIndex = 36;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(148, 190);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(327, 22);
            this.txtPrice.TabIndex = 35;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(148, 151);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(327, 22);
            this.txtQty.TabIndex = 34;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(148, 64);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(327, 76);
            this.txtDesc.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 22);
            this.txtName.TabIndex = 32;
            // 
            // lblJustification
            // 
            this.lblJustification.AutoSize = true;
            this.lblJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustification.Location = new System.Drawing.Point(4, 260);
            this.lblJustification.Name = "lblJustification";
            this.lblJustification.Size = new System.Drawing.Size(120, 25);
            this.lblJustification.TabIndex = 31;
            this.lblJustification.Text = "Justification:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(32, 222);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(92, 25);
            this.lblLocation.TabIndex = 30;
            this.lblLocation.Text = "Location:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(62, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(32, 147);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(91, 25);
            this.lblQty.TabIndex = 28;
            this.lblQty.Text = "Quantity:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(8, 60);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(115, 25);
            this.lblDesc.TabIndex = 27;
            this.lblDesc.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 25);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Item Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 38);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Create Purchase Order";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(23, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(738, 9);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(138, 25);
            this.lblEmpName.TabIndex = 41;
            this.lblEmpName.Text = "Mike Donovan";
            this.lblEmpName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(660, 34);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(216, 25);
            this.lblDept.TabIndex = 42;
            this.lblDept.Text = "Information Technology";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSuper
            // 
            this.lblSuper.AutoSize = true;
            this.lblSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuper.Location = new System.Drawing.Point(771, 59);
            this.lblSuper.Name = "lblSuper";
            this.lblSuper.Size = new System.Drawing.Size(105, 25);
            this.lblSuper.TabIndex = 43;
            this.lblSuper.Text = "John Wick";
            this.lblSuper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(16, 31);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(103, 25);
            this.lblSub.TabIndex = 44;
            this.lblSub.Text = "Sub Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(67, 69);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(52, 25);
            this.lblTax.TabIndex = 45;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(57, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubNum
            // 
            this.lblSubNum.AutoSize = true;
            this.lblSubNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNum.Location = new System.Drawing.Point(137, 30);
            this.lblSubNum.Name = "lblSubNum";
            this.lblSubNum.Size = new System.Drawing.Size(61, 25);
            this.lblSubNum.TabIndex = 47;
            this.lblSubNum.Text = "$0.00";
            // 
            // lblTaxNum
            // 
            this.lblTaxNum.AutoSize = true;
            this.lblTaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxNum.Location = new System.Drawing.Point(137, 69);
            this.lblTaxNum.Name = "lblTaxNum";
            this.lblTaxNum.Size = new System.Drawing.Size(61, 25);
            this.lblTaxNum.TabIndex = 48;
            this.lblTaxNum.Text = "$0.00";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(137, 106);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(61, 25);
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
            this.grpTotal.Location = new System.Drawing.Point(593, 369);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(287, 157);
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
            this.grpItem.Location = new System.Drawing.Point(28, 97);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(512, 429);
            this.grpItem.TabIndex = 51;
            this.grpItem.TabStop = false;
            // 
            // lblOrderNumberLabel
            // 
            this.lblOrderNumberLabel.AutoSize = true;
            this.lblOrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumberLabel.Location = new System.Drawing.Point(588, 97);
            this.lblOrderNumberLabel.Name = "lblOrderNumberLabel";
            this.lblOrderNumberLabel.Size = new System.Drawing.Size(142, 25);
            this.lblOrderNumberLabel.TabIndex = 50;
            this.lblOrderNumberLabel.Text = "Order Number:";
            this.lblOrderNumberLabel.Visible = false;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(752, 97);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(23, 25);
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
            this.btnAddToOrder.Location = new System.Drawing.Point(593, 307);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(137, 53);
            this.btnAddToOrder.TabIndex = 39;
            this.btnAddToOrder.Text = "Add To Existing Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblEnterOrder
            // 
            this.lblEnterOrder.AutoSize = true;
            this.lblEnterOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterOrder.Location = new System.Drawing.Point(588, 263);
            this.lblEnterOrder.Name = "lblEnterOrder";
            this.lblEnterOrder.Size = new System.Drawing.Size(142, 25);
            this.lblEnterOrder.TabIndex = 52;
            this.lblEnterOrder.Text = "Order Number:";
            this.lblEnterOrder.Visible = false;
            // 
            // txtEnterOrder
            // 
            this.txtEnterOrder.Location = new System.Drawing.Point(757, 267);
            this.txtEnterOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnterOrder.Name = "txtEnterOrder";
            this.txtEnterOrder.Size = new System.Drawing.Size(123, 22);
            this.txtEnterOrder.TabIndex = 39;
            this.txtEnterOrder.Visible = false;
            this.txtEnterOrder.TextChanged += new System.EventHandler(this.txtEnterOrder_TextChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(743, 307);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(137, 53);
            this.btnNewOrder.TabIndex = 53;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Visible = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(593, 125);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(287, 132);
            this.lstItems.TabIndex = 54;
            // 
            // CreatePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 547);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

