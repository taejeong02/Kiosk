﻿namespace KioskProject
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
            this.Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paymentButton.Location = new System.Drawing.Point(83, 178);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(210, 155);
            this.paymentButton.TabIndex = 0;
            this.paymentButton.Text = "카드삽입";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Count.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Count.Location = new System.Drawing.Point(252, 14);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(98, 26);
            this.Count.TabIndex = 1;
            this.Count.Text = "남은 시간: 10초";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PaymentcompletedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 568);
            this.ControlBox = false;
            this.Controls.Add(this.Count);
            this.Controls.Add(this.paymentButton);
            this.Name = "PaymentcompletedUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Label Count;
    }
}