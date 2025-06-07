namespace KioskProject
{
    partial class Payment
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minus_btn;
        private System.Windows.Forms.Button Plus_btn;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PerPersonAmount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ChangePaymentMethod_btn;
        private System.Windows.Forms.Button CancelPaying_btn;
    }
}