using System.Runtime.CompilerServices;

namespace KioskProject
{
    partial class PaymentUI
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
            this.ChangePaymentMethod_btn = new System.Windows.Forms.Button();
            this.PerPersonAmount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelPaying_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.Plus_btn = new System.Windows.Forms.Button();
            this.Minus_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangePaymentMethod_btn
            // 
            this.ChangePaymentMethod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePaymentMethod_btn.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.ChangePaymentMethod_btn.Location = new System.Drawing.Point(12, 804);
            this.ChangePaymentMethod_btn.Name = "ChangePaymentMethod_btn";
            this.ChangePaymentMethod_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangePaymentMethod_btn.Size = new System.Drawing.Size(145, 42);
            this.ChangePaymentMethod_btn.TabIndex = 40;
            this.ChangePaymentMethod_btn.Text = "결제수단 변경";
            this.ChangePaymentMethod_btn.UseVisualStyleBackColor = true;
            this.ChangePaymentMethod_btn.Click += new System.EventHandler(this.ChangePaymentMethod_btn_Click);
            // 
            // PerPersonAmount
            // 
            this.PerPersonAmount.AutoSize = true;
            this.PerPersonAmount.Cursor = System.Windows.Forms.Cursors.No;
            this.PerPersonAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerPersonAmount.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.PerPersonAmount.Location = new System.Drawing.Point(486, 21);
            this.PerPersonAmount.Name = "PerPersonAmount";
            this.PerPersonAmount.Size = new System.Drawing.Size(63, 25);
            this.PerPersonAmount.TabIndex = 39;
            this.PerPersonAmount.Text = "label6";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 724);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // CancelPaying_btn
            // 
            this.CancelPaying_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelPaying_btn.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.CancelPaying_btn.Location = new System.Drawing.Point(427, 804);
            this.CancelPaying_btn.Name = "CancelPaying_btn";
            this.CancelPaying_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelPaying_btn.Size = new System.Drawing.Size(145, 42);
            this.CancelPaying_btn.TabIndex = 36;
            this.CancelPaying_btn.Text = "결제 취소";
            this.CancelPaying_btn.UseVisualStyleBackColor = true;
            this.CancelPaying_btn.Click += new System.EventHandler(this.CancelPaying_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.label3.Location = new System.Drawing.Point(326, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "1인당 결제금액 :";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCount.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.labelCount.Location = new System.Drawing.Point(201, 21);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 25);
            this.labelCount.TabIndex = 33;
            this.labelCount.Text = "1명";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Plus_btn
            // 
            this.Plus_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Plus_btn.Location = new System.Drawing.Point(254, 15);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.Size = new System.Drawing.Size(44, 34);
            this.Plus_btn.TabIndex = 32;
            this.Plus_btn.Text = "+";
            this.Plus_btn.UseVisualStyleBackColor = false;
            // 
            // Minus_btn
            // 
            this.Minus_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Minus_btn.Location = new System.Drawing.Point(151, 16);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.Size = new System.Drawing.Size(44, 34);
            this.Minus_btn.TabIndex = 31;
            this.Minus_btn.Text = "-";
            this.Minus_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "총 인원 수 :";
            // 
            // PaymentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.ChangePaymentMethod_btn);
            this.Controls.Add(this.PerPersonAmount);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CancelPaying_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.Plus_btn);
            this.Controls.Add(this.Minus_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentUI";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangePaymentMethod_btn;
        private System.Windows.Forms.Label PerPersonAmount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CancelPaying_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button Plus_btn;
        private System.Windows.Forms.Button Minus_btn;
        private System.Windows.Forms.Label label1;
    }
}