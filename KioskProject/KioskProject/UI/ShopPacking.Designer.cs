namespace KioskProject
{
    partial class ShopPacking
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
            this.test = new MetroFramework.Controls.MetroLabel();
            this.welcome_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(32, 991);
            this.test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(94, 19);
            this.test.TabIndex = 9;
            this.test.Text = "ㅤㅤㅤㅤㅤ111";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_lbl.Location = new System.Drawing.Point(368, 494);
            this.welcome_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(79, 19);
            this.welcome_lbl.TabIndex = 10;
            this.welcome_lbl.Text = "어서오세요";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(279, 797);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(120, 70);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "매장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(442, 797);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(120, 70);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "포장";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ShopPacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 1322);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.test);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopPacking";
            this.Padding = new System.Windows.Forms.Padding(29, 90, 29, 30);
            this.Load += new System.EventHandler(this.ShopPacking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel test;
        private MetroFramework.Controls.MetroLabel welcome_lbl;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}