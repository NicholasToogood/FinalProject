namespace Desktop
{
    partial class Main
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
            this.MainTab = new MdiTabControl.TabControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.btnModPO = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalculatePension = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Location = new System.Drawing.Point(200, 3);
            this.MainTab.MenuRenderer = null;
            this.MainTab.Name = "MainTab";
            this.MainTab.Size = new System.Drawing.Size(706, 500);
            this.MainTab.TabCloseButtonImage = null;
            this.MainTab.TabCloseButtonImageDisabled = null;
            this.MainTab.TabCloseButtonImageHot = null;
            this.MainTab.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 57);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "ABC Academy";
            // 
            // btnCreatePO
            // 
            this.btnCreatePO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePO.Location = new System.Drawing.Point(8, 67);
            this.btnCreatePO.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(186, 32);
            this.btnCreatePO.TabIndex = 8;
            this.btnCreatePO.Text = "Create PO";
            this.btnCreatePO.UseVisualStyleBackColor = true;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
            // 
            // btnModPO
            // 
            this.btnModPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPO.Location = new System.Drawing.Point(8, 104);
            this.btnModPO.Margin = new System.Windows.Forms.Padding(2);
            this.btnModPO.Name = "btnModPO";
            this.btnModPO.Size = new System.Drawing.Size(186, 32);
            this.btnModPO.TabIndex = 9;
            this.btnModPO.Text = "Modify PO";
            this.btnModPO.UseVisualStyleBackColor = true;
            this.btnModPO.Click += new System.EventHandler(this.btnModPO_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(8, 216);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(186, 32);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.Location = new System.Drawing.Point(8, 252);
            this.btnSearchEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(186, 32);
            this.btnSearchEmp.TabIndex = 11;
            this.btnSearchEmp.Text = "Search Employee";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cost-of-living Increase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculatePension
            // 
            this.btnCalculatePension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePension.Location = new System.Drawing.Point(8, 363);
            this.btnCalculatePension.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculatePension.Name = "btnCalculatePension";
            this.btnCalculatePension.Size = new System.Drawing.Size(186, 32);
            this.btnCalculatePension.TabIndex = 13;
            this.btnCalculatePension.Text = "Calculate Pension";
            this.btnCalculatePension.UseVisualStyleBackColor = true;
            this.btnCalculatePension.Click += new System.EventHandler(this.btnCalculatePension_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 508);
            this.Controls.Add(this.btnCalculatePension);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnModPO);
            this.Controls.Add(this.btnCreatePO);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.MainTab);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MdiTabControl.TabControl MainTab;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreatePO;
        private System.Windows.Forms.Button btnModPO;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalculatePension;
    }
}