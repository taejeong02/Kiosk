﻿namespace KioskProject
{
    partial class AdminRegistUI
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.registerID_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.registerPW_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.register_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "PW:";
            // 
            // registerID_txtbox
            // 
            this.registerID_txtbox.Location = new System.Drawing.Point(62, 68);
            this.registerID_txtbox.Name = "registerID_txtbox";
            this.registerID_txtbox.Size = new System.Drawing.Size(110, 23);
            this.registerID_txtbox.TabIndex = 2;
            // 
            // registerPW_txtbox
            // 
            this.registerPW_txtbox.Location = new System.Drawing.Point(62, 97);
            this.registerPW_txtbox.Name = "registerPW_txtbox";
            this.registerPW_txtbox.PasswordChar = '*';
            this.registerPW_txtbox.Size = new System.Drawing.Size(110, 23);
            this.registerPW_txtbox.TabIndex = 3;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(178, 68);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(60, 52);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Register";
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "관리자 회원가입";
            // 
            // AdminRegistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 159);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.registerPW_txtbox);
            this.Controls.Add(this.registerID_txtbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdminRegistUI";
            this.Load += new System.EventHandler(this.AdminRegistUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox registerID_txtbox;
        private MetroFramework.Controls.MetroTextBox registerPW_txtbox;
        private MetroFramework.Controls.MetroButton register_btn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}