namespace KioskProject
{
    partial class CartUI
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
            this.cardBtn = new System.Windows.Forms.Button();
            this.cashBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardBtn
            // 
            this.cardBtn.Location = new System.Drawing.Point(12, 225);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(250, 202);
            this.cardBtn.TabIndex = 0;
            this.cardBtn.Text = "카드 결제";
            this.cardBtn.UseVisualStyleBackColor = true;
            this.cardBtn.Click += new System.EventHandler(this.cardBtn_Click);
            // 
            // cashBtn
            // 
            this.cashBtn.Location = new System.Drawing.Point(322, 225);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(250, 202);
            this.cashBtn.TabIndex = 1;
            this.cashBtn.Text = "현금 결제";
            this.cashBtn.UseVisualStyleBackColor = true;
            this.cashBtn.Click += new System.EventHandler(this.cashBtn_Click);
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.cashBtn);
            this.Controls.Add(this.cardBtn);
            this.Name = "CartUI";
            this.Text = "CartUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cardBtn;
        private System.Windows.Forms.Button cashBtn;
    }
}