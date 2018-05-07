namespace Desktop
{
    partial class ConfirmCalculaltePayroll
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
            this.txtPayrollCode = new System.Windows.Forms.TextBox();
            this.lblPayroll = new System.Windows.Forms.Label();
            this.btnEnterPayrollCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPayrollCode
            // 
            this.txtPayrollCode.Location = new System.Drawing.Point(130, 36);
            this.txtPayrollCode.Name = "txtPayrollCode";
            this.txtPayrollCode.Size = new System.Drawing.Size(100, 20);
            this.txtPayrollCode.TabIndex = 0;
            // 
            // lblPayroll
            // 
            this.lblPayroll.AutoSize = true;
            this.lblPayroll.Location = new System.Drawing.Point(27, 39);
            this.lblPayroll.Name = "lblPayroll";
            this.lblPayroll.Size = new System.Drawing.Size(97, 13);
            this.lblPayroll.TabIndex = 1;
            this.lblPayroll.Text = "Enter Payroll Code:";
            // 
            // btnEnterPayrollCode
            // 
            this.btnEnterPayrollCode.Location = new System.Drawing.Point(246, 30);
            this.btnEnterPayrollCode.Name = "btnEnterPayrollCode";
            this.btnEnterPayrollCode.Size = new System.Drawing.Size(81, 30);
            this.btnEnterPayrollCode.TabIndex = 2;
            this.btnEnterPayrollCode.Text = "&Enter";
            this.btnEnterPayrollCode.UseVisualStyleBackColor = true;
            this.btnEnterPayrollCode.Click += new System.EventHandler(this.btnEnterPayrollCode_Click);
            // 
            // ConfirmCalculaltePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 95);
            this.Controls.Add(this.btnEnterPayrollCode);
            this.Controls.Add(this.lblPayroll);
            this.Controls.Add(this.txtPayrollCode);
            this.Name = "ConfirmCalculaltePayroll";
            this.Text = "ConfirmCalculaltePayroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPayrollCode;
        private System.Windows.Forms.Label lblPayroll;
        private System.Windows.Forms.Button btnEnterPayrollCode;
    }
}