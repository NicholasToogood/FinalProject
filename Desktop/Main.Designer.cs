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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainTab = new MdiTabControl.TabControl();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.btnModPO = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnSickDays = new System.Windows.Forms.Button();
            this.btnCostOfLiving = new System.Windows.Forms.Button();
            this.btnProcessPO = new System.Windows.Forms.Button();
            this.btnCalculatePension = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnSalaryChanges = new System.Windows.Forms.Button();
            this.btnInquirePayroll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btnCreatePO
            // 
            this.btnCreatePO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePO.Location = new System.Drawing.Point(8, 98);
            this.btnCreatePO.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(186, 32);
            this.btnCreatePO.TabIndex = 8;
            this.btnCreatePO.Text = "Create PO";
            this.btnCreatePO.UseVisualStyleBackColor = true;
            this.btnCreatePO.Visible = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
            // 
            // btnModPO
            // 
            this.btnModPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPO.Location = new System.Drawing.Point(8, 133);
            this.btnModPO.Margin = new System.Windows.Forms.Padding(2);
            this.btnModPO.Name = "btnModPO";
            this.btnModPO.Size = new System.Drawing.Size(186, 32);
            this.btnModPO.TabIndex = 9;
            this.btnModPO.Text = "Modify PO";
            this.btnModPO.UseVisualStyleBackColor = true;
            this.btnModPO.Visible = false;
            this.btnModPO.Click += new System.EventHandler(this.btnModPO_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(6, 226);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(186, 32);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Visible = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnSickDays
            // 
            this.btnSickDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSickDays.Location = new System.Drawing.Point(6, 386);
            this.btnSickDays.Margin = new System.Windows.Forms.Padding(2);
            this.btnSickDays.Name = "btnSickDays";
            this.btnSickDays.Size = new System.Drawing.Size(186, 32);
            this.btnSickDays.TabIndex = 11;
            this.btnSickDays.Text = "Add Sick Days";
            this.btnSickDays.UseVisualStyleBackColor = true;
            this.btnSickDays.Visible = false;
            this.btnSickDays.Click += new System.EventHandler(this.btnSickDays_Click);
            // 
            // btnCostOfLiving
            // 
            this.btnCostOfLiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostOfLiving.Location = new System.Drawing.Point(6, 262);
            this.btnCostOfLiving.Margin = new System.Windows.Forms.Padding(2);
            this.btnCostOfLiving.Name = "btnCostOfLiving";
            this.btnCostOfLiving.Size = new System.Drawing.Size(186, 32);
            this.btnCostOfLiving.TabIndex = 12;
            this.btnCostOfLiving.Text = "Cost-of-living Increase";
            this.btnCostOfLiving.UseVisualStyleBackColor = true;
            this.btnCostOfLiving.Visible = false;
            this.btnCostOfLiving.Click += new System.EventHandler(this.btnCostOfLiving_Click);
            // 
            // btnProcessPO
            // 
            this.btnProcessPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPO.Location = new System.Drawing.Point(9, 169);
            this.btnProcessPO.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessPO.Name = "btnProcessPO";
            this.btnProcessPO.Size = new System.Drawing.Size(186, 32);
            this.btnProcessPO.TabIndex = 13;
            this.btnProcessPO.Text = "Process PO";
            this.btnProcessPO.UseVisualStyleBackColor = true;
            this.btnProcessPO.Visible = false;
            this.btnProcessPO.Click += new System.EventHandler(this.btnProcessPO_Click);
            // 
            // btnCalculatePension
            // 
            this.btnCalculatePension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePension.Location = new System.Drawing.Point(8, 298);
            this.btnCalculatePension.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculatePension.Name = "btnCalculatePension";
            this.btnCalculatePension.Size = new System.Drawing.Size(186, 32);
            this.btnCalculatePension.TabIndex = 14;
            this.btnCalculatePension.Text = "Calculate Pension";
            this.btnCalculatePension.UseVisualStyleBackColor = true;
            this.btnCalculatePension.Visible = false;
            this.btnCalculatePension.Click += new System.EventHandler(this.btnCalculatePension_Click);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyEmployee.Location = new System.Drawing.Point(6, 458);
            this.btnModifyEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(186, 32);
            this.btnModifyEmployee.TabIndex = 15;
            this.btnModifyEmployee.Text = "Modify Employee";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Visible = false;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnSalaryChanges
            // 
            this.btnSalaryChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryChanges.Location = new System.Drawing.Point(6, 422);
            this.btnSalaryChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalaryChanges.Name = "btnSalaryChanges";
            this.btnSalaryChanges.Size = new System.Drawing.Size(186, 32);
            this.btnSalaryChanges.TabIndex = 16;
            this.btnSalaryChanges.Text = "Employee Raise";
            this.btnSalaryChanges.UseVisualStyleBackColor = true;
            this.btnSalaryChanges.Visible = false;
            this.btnSalaryChanges.Click += new System.EventHandler(this.btnSalaryChanges_Click);
            // 
            // btnInquirePayroll
            // 
            this.btnInquirePayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquirePayroll.Location = new System.Drawing.Point(9, 334);
            this.btnInquirePayroll.Margin = new System.Windows.Forms.Padding(2);
            this.btnInquirePayroll.Name = "btnInquirePayroll";
            this.btnInquirePayroll.Size = new System.Drawing.Size(186, 32);
            this.btnInquirePayroll.TabIndex = 17;
            this.btnInquirePayroll.Text = "Inquire Payroll Info";
            this.btnInquirePayroll.UseVisualStyleBackColor = true;
            this.btnInquirePayroll.Visible = false;
            this.btnInquirePayroll.Click += new System.EventHandler(this.btnInquirePayroll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInquirePayroll);
            this.Controls.Add(this.btnSalaryChanges);
            this.Controls.Add(this.btnModifyEmployee);
            this.Controls.Add(this.btnCalculatePension);
            this.Controls.Add(this.btnProcessPO);
            this.Controls.Add(this.btnCostOfLiving);
            this.Controls.Add(this.btnSickDays);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnModPO);
            this.Controls.Add(this.btnCreatePO);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MdiTabControl.TabControl MainTab;
        private System.Windows.Forms.Button btnCreatePO;
        private System.Windows.Forms.Button btnModPO;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnSickDays;
        private System.Windows.Forms.Button btnCostOfLiving;
        private System.Windows.Forms.Button btnProcessPO;
        private System.Windows.Forms.Button btnCalculatePension;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnSalaryChanges;
        private System.Windows.Forms.Button btnInquirePayroll;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}