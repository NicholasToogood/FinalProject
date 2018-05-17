namespace Desktop
{
    partial class CostOfLivingIncreaseHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostOfLivingIncreaseHR));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnRequestIncrease = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpDateOfIncrease = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPercentageIncreaseRequest = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.btnRequestIncrease);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.dtpDateOfIncrease);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtPercentageIncreaseRequest);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 86);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cost-of-living Increase";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(193, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "%";
            // 
            // btnRequestIncrease
            // 
            this.btnRequestIncrease.Location = new System.Drawing.Point(317, 30);
            this.btnRequestIncrease.Name = "btnRequestIncrease";
            this.btnRequestIncrease.Size = new System.Drawing.Size(112, 32);
            this.btnRequestIncrease.TabIndex = 4;
            this.btnRequestIncrease.Text = "Request Increase";
            this.btnRequestIncrease.UseVisualStyleBackColor = true;
            this.btnRequestIncrease.Click += new System.EventHandler(this.btnRequestIncrease_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(48, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "Date of Increase:";
            // 
            // dtpDateOfIncrease
            // 
            this.dtpDateOfIncrease.Location = new System.Drawing.Point(147, 47);
            this.dtpDateOfIncrease.Name = "dtpDateOfIncrease";
            this.dtpDateOfIncrease.Size = new System.Drawing.Size(141, 20);
            this.dtpDateOfIncrease.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Percentage of Increase:";
            // 
            // txtPercentageIncreaseRequest
            // 
            this.txtPercentageIncreaseRequest.Location = new System.Drawing.Point(147, 21);
            this.txtPercentageIncreaseRequest.Name = "txtPercentageIncreaseRequest";
            this.txtPercentageIncreaseRequest.Size = new System.Drawing.Size(45, 20);
            this.txtPercentageIncreaseRequest.TabIndex = 0;
            this.txtPercentageIncreaseRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CostOfLivingIncreaseHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 182);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CostOfLivingIncreaseHR";
            this.Text = "CostOfLivingIncreaseHR";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnRequestIncrease;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtpDateOfIncrease;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtPercentageIncreaseRequest;
    }
}