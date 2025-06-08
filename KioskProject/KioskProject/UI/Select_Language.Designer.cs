namespace KioskProject
{
    partial class Select_Language
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
            this.Korean = new System.Windows.Forms.Button();
            this.China = new System.Windows.Forms.Button();
            this.English = new System.Windows.Forms.Button();
            this.Japan = new System.Windows.Forms.Button();
            this.test = new MetroFramework.Controls.MetroLabel();
            this.welcome_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cbolang = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // Korean
            // 
            this.Korean.BackColor = System.Drawing.Color.Transparent;
            this.Korean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Korean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Korean.FlatAppearance.BorderSize = 0;
            this.Korean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Korean.Location = new System.Drawing.Point(319, 47);
            this.Korean.Name = "Korean";
            this.Korean.Size = new System.Drawing.Size(63, 36);
            this.Korean.TabIndex = 5;
            this.Korean.UseVisualStyleBackColor = false;
            this.Korean.Click += new System.EventHandler(this.Korean_Click);
            // 
            // China
            // 
            this.China.BackColor = System.Drawing.Color.Transparent;
            this.China.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.China.Cursor = System.Windows.Forms.Cursors.Hand;
            this.China.FlatAppearance.BorderSize = 0;
            this.China.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.China.Location = new System.Drawing.Point(388, 47);
            this.China.Name = "China";
            this.China.Size = new System.Drawing.Size(63, 36);
            this.China.TabIndex = 6;
            this.China.UseVisualStyleBackColor = false;
            this.China.Click += new System.EventHandler(this.China_Click);
            // 
            // English
            // 
            this.English.BackColor = System.Drawing.Color.Transparent;
            this.English.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.English.Cursor = System.Windows.Forms.Cursors.Hand;
            this.English.FlatAppearance.BorderSize = 0;
            this.English.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.English.Location = new System.Drawing.Point(457, 47);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(63, 36);
            this.English.TabIndex = 7;
            this.English.UseVisualStyleBackColor = true;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Japan
            // 
            this.Japan.BackColor = System.Drawing.Color.Transparent;
            this.Japan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Japan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Japan.FlatAppearance.BorderSize = 0;
            this.Japan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Japan.Location = new System.Drawing.Point(526, 47);
            this.Japan.Name = "Japan";
            this.Japan.Size = new System.Drawing.Size(63, 36);
            this.Japan.TabIndex = 8;
            this.Japan.UseVisualStyleBackColor = true;
            this.Japan.Click += new System.EventHandler(this.Japan_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(23, 861);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(51, 19);
            this.test.TabIndex = 9;
            this.test.Text = "관리자";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_lbl.Location = new System.Drawing.Point(257, 330);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(79, 19);
            this.welcome_lbl.TabIndex = 10;
            this.welcome_lbl.Text = "어서오세요";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(195, 531);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(84, 46);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "매장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(310, 531);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(84, 46);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "포장";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cbolang
            // 
            this.cbolang.FormattingEnabled = true;
            this.cbolang.ItemHeight = 23;
            this.cbolang.Location = new System.Drawing.Point(9, 16);
            this.cbolang.Name = "cbolang";
            this.cbolang.Size = new System.Drawing.Size(133, 29);
            this.cbolang.TabIndex = 13;
            // 
            // Select_Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 900);
            this.Controls.Add(this.cbolang);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Japan);
            this.Controls.Add(this.English);
            this.Controls.Add(this.China);
            this.Controls.Add(this.Korean);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select_Language";
            this.Load += new System.EventHandler(this.Select_Language_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Korean;
        private System.Windows.Forms.Button China;
        private System.Windows.Forms.Button English;
        private System.Windows.Forms.Button Japan;
        private MetroFramework.Controls.MetroLabel test;
        private MetroFramework.Controls.MetroLabel welcome_lbl;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox cbolang;
    }
}