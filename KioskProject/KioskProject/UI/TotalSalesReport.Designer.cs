namespace KioskProject.UI
{
    partial class TotalSalesReport
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
            this.totalsales_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // totalsales_lbl
            // 
            this.totalsales_lbl.AutoSize = true;
            this.totalsales_lbl.Location = new System.Drawing.Point(39, 84);
            this.totalsales_lbl.Name = "totalsales_lbl";
            this.totalsales_lbl.Size = new System.Drawing.Size(51, 19);
            this.totalsales_lbl.TabIndex = 0;
            this.totalsales_lbl.Text = "총매출";
            // 
            // TotalSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 565);
            this.Controls.Add(this.totalsales_lbl);
            this.Name = "TotalSalesReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel totalsales_lbl;
    }
}