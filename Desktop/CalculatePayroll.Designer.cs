namespace Desktop
{
    partial class CalculatePayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatePayroll));
            this.GetAllPaystubsForTodayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPayStubs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GetAllPaystubsForTodayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayStubs)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAllPaystubsForTodayBindingSource
            // 
            this.GetAllPaystubsForTodayBindingSource.DataMember = "GetAllPaystubsForToday";
            // 
            // dataGridViewPayStubs
            // 
            this.dataGridViewPayStubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayStubs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPayStubs.Name = "dataGridViewPayStubs";
            this.dataGridViewPayStubs.ReadOnly = true;
            this.dataGridViewPayStubs.Size = new System.Drawing.Size(680, 151);
            this.dataGridViewPayStubs.TabIndex = 1;
            // 
            // CalculatePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 241);
            this.Controls.Add(this.dataGridViewPayStubs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatePayroll";
            this.Text = "CalculatePayroll";
            this.Load += new System.EventHandler(this.CalculatePayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetAllPaystubsForTodayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayStubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource GetAllPaystubsForTodayBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPayStubs;
    }
}