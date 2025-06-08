namespace KioskProject
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
            this.totalprice_lbl = new MetroFramework.Controls.MetroLabel();
            this.monthsales_lbl = new MetroFramework.Controls.MetroLabel();
            this.monthprice_lbl = new MetroFramework.Controls.MetroLabel();
            this.daysales_lbl = new MetroFramework.Controls.MetroLabel();
            this.dayprice_lbl = new MetroFramework.Controls.MetroLabel();
            this.yearsales_lbl = new MetroFramework.Controls.MetroLabel();
            this.yearprice_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // totalsales_lbl
            // 
            this.totalsales_lbl.AutoSize = true;
            this.totalsales_lbl.Location = new System.Drawing.Point(23, 83);
            this.totalsales_lbl.Name = "totalsales_lbl";
            this.totalsales_lbl.Size = new System.Drawing.Size(51, 19);
            this.totalsales_lbl.TabIndex = 0;
            this.totalsales_lbl.Text = "총매출";
            // 
            // totalprice_lbl
            // 
            this.totalprice_lbl.AutoSize = true;
            this.totalprice_lbl.Location = new System.Drawing.Point(80, 83);
            this.totalprice_lbl.Name = "totalprice_lbl";
            this.totalprice_lbl.Size = new System.Drawing.Size(81, 19);
            this.totalprice_lbl.TabIndex = 1;
            this.totalprice_lbl.Text = "metroLabel1";
            // 
            // monthsales_lbl
            // 
            this.monthsales_lbl.AutoSize = true;
            this.monthsales_lbl.Location = new System.Drawing.Point(23, 139);
            this.monthsales_lbl.Name = "monthsales_lbl";
            this.monthsales_lbl.Size = new System.Drawing.Size(51, 19);
            this.monthsales_lbl.TabIndex = 2;
            this.monthsales_lbl.Text = "월매출";
            // 
            // monthprice_lbl
            // 
            this.monthprice_lbl.AutoSize = true;
            this.monthprice_lbl.Location = new System.Drawing.Point(80, 139);
            this.monthprice_lbl.Name = "monthprice_lbl";
            this.monthprice_lbl.Size = new System.Drawing.Size(81, 19);
            this.monthprice_lbl.TabIndex = 3;
            this.monthprice_lbl.Text = "metroLabel1";
            // 
            // daysales_lbl
            // 
            this.daysales_lbl.AutoSize = true;
            this.daysales_lbl.Location = new System.Drawing.Point(246, 139);
            this.daysales_lbl.Name = "daysales_lbl";
            this.daysales_lbl.Size = new System.Drawing.Size(51, 19);
            this.daysales_lbl.TabIndex = 4;
            this.daysales_lbl.Text = "일매출";
            // 
            // dayprice_lbl
            // 
            this.dayprice_lbl.AutoSize = true;
            this.dayprice_lbl.Location = new System.Drawing.Point(303, 139);
            this.dayprice_lbl.Name = "dayprice_lbl";
            this.dayprice_lbl.Size = new System.Drawing.Size(81, 19);
            this.dayprice_lbl.TabIndex = 5;
            this.dayprice_lbl.Text = "metroLabel1";
            // 
            // yearsales_lbl
            // 
            this.yearsales_lbl.AutoSize = true;
            this.yearsales_lbl.Location = new System.Drawing.Point(246, 83);
            this.yearsales_lbl.Name = "yearsales_lbl";
            this.yearsales_lbl.Size = new System.Drawing.Size(51, 19);
            this.yearsales_lbl.TabIndex = 6;
            this.yearsales_lbl.Text = "년매출";
            // 
            // yearprice_lbl
            // 
            this.yearprice_lbl.AutoSize = true;
            this.yearprice_lbl.Location = new System.Drawing.Point(303, 83);
            this.yearprice_lbl.Name = "yearprice_lbl";
            this.yearprice_lbl.Size = new System.Drawing.Size(81, 19);
            this.yearprice_lbl.TabIndex = 7;
            this.yearprice_lbl.Text = "metroLabel1";
            // 
            // TotalSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.yearprice_lbl);
            this.Controls.Add(this.yearsales_lbl);
            this.Controls.Add(this.dayprice_lbl);
            this.Controls.Add(this.daysales_lbl);
            this.Controls.Add(this.monthprice_lbl);
            this.Controls.Add(this.monthsales_lbl);
            this.Controls.Add(this.totalprice_lbl);
            this.Controls.Add(this.totalsales_lbl);
            this.Name = "TotalSalesReport";
            this.Text = "매출 정보";
            this.Load += new System.EventHandler(this.TotalSalesReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel totalsales_lbl;
        private MetroFramework.Controls.MetroLabel totalprice_lbl;
        private MetroFramework.Controls.MetroLabel monthsales_lbl;
        private MetroFramework.Controls.MetroLabel monthprice_lbl;
        private MetroFramework.Controls.MetroLabel daysales_lbl;
        private MetroFramework.Controls.MetroLabel dayprice_lbl;
        private MetroFramework.Controls.MetroLabel yearsales_lbl;
        private MetroFramework.Controls.MetroLabel yearprice_lbl;
    }
}