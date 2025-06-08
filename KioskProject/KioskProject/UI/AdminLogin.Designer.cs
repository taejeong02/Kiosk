namespace KioskProject
{
    partial class AdminLogin
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
            this.adminId_lbl = new MetroFramework.Controls.MetroLabel();
            this.adminId_txtBox = new MetroFramework.Controls.MetroTextBox();
            this.adminPw_txtBox = new MetroFramework.Controls.MetroTextBox();
            this.adminPw_lbl = new MetroFramework.Controls.MetroLabel();
            this.Login_btn = new MetroFramework.Controls.MetroButton();
            this.regist_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // adminId_lbl
            // 
            this.adminId_lbl.AutoSize = true;
            this.adminId_lbl.Location = new System.Drawing.Point(23, 63);
            this.adminId_lbl.Name = "adminId_lbl";
            this.adminId_lbl.Size = new System.Drawing.Size(28, 19);
            this.adminId_lbl.TabIndex = 0;
            this.adminId_lbl.Text = "ID :";
            // 
            // adminId_txtBox
            // 
            this.adminId_txtBox.Location = new System.Drawing.Point(57, 63);
            this.adminId_txtBox.Name = "adminId_txtBox";
            this.adminId_txtBox.Size = new System.Drawing.Size(138, 23);
            this.adminId_txtBox.TabIndex = 1;
            // 
            // adminPw_txtBox
            // 
            this.adminPw_txtBox.Location = new System.Drawing.Point(57, 92);
            this.adminPw_txtBox.Name = "adminPw_txtBox";
            this.adminPw_txtBox.Size = new System.Drawing.Size(138, 23);
            this.adminPw_txtBox.TabIndex = 3;
            // 
            // adminPw_lbl
            // 
            this.adminPw_lbl.AutoSize = true;
            this.adminPw_lbl.Location = new System.Drawing.Point(23, 92);
            this.adminPw_lbl.Name = "adminPw_lbl";
            this.adminPw_lbl.Size = new System.Drawing.Size(37, 19);
            this.adminPw_lbl.TabIndex = 2;
            this.adminPw_lbl.Text = "PW :";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(201, 63);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(72, 52);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Login";
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // regist_btn
            // 
            this.regist_btn.Location = new System.Drawing.Point(123, 121);
            this.regist_btn.Name = "regist_btn";
            this.regist_btn.Size = new System.Drawing.Size(72, 23);
            this.regist_btn.TabIndex = 5;
            this.regist_btn.Text = "Regist";
            this.regist_btn.Click += new System.EventHandler(this.regist_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "관리자 로그인";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.regist_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.adminPw_txtBox);
            this.Controls.Add(this.adminPw_lbl);
            this.Controls.Add(this.adminId_txtBox);
            this.Controls.Add(this.adminId_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel adminId_lbl;
        private MetroFramework.Controls.MetroTextBox adminId_txtBox;
        private MetroFramework.Controls.MetroTextBox adminPw_txtBox;
        private MetroFramework.Controls.MetroLabel adminPw_lbl;
        private MetroFramework.Controls.MetroButton Login_btn;
        private MetroFramework.Controls.MetroButton regist_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}