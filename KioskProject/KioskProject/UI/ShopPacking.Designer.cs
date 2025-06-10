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
            this.test.Location = new System.Drawing.Point(26, 826);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(99, 20);
            this.test.TabIndex = 9;
            this.test.Text = "ㅤㅤㅤㅤㅤ111";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_lbl.Location = new System.Drawing.Point(294, 412);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(84, 20);
            this.welcome_lbl.TabIndex = 10;
            this.welcome_lbl.Text = "어서오세요";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(223, 664);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 58);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "매장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(354, 664);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(96, 58);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "포장";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ShopPacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 1102);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.test);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopPacking";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
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