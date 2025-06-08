namespace KioskProject
{
    partial class PaymentcompletedUI
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
            this.paymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(82, 166);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(210, 155);
            this.paymentButton.TabIndex = 0;
            this.paymentButton.Text = "결제완료";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // PaymentcompletedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 568);
            this.ControlBox = false;
            this.Controls.Add(this.paymentButton);
            this.Name = "PaymentcompletedUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paymentButton;
    }
}