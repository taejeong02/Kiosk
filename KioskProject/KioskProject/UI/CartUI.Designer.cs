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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cart_lbl = new MetroFramework.Controls.MetroLabel();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.cash_btn = new MetroFramework.Controls.MetroButton();
            this.card_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(23, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(538, 522);
            this.dataGridView1.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "번호";
            this.Num.Name = "Num";
            // 
            // Name
            // 
            this.Name.HeaderText = "상품명";
            this.Name.Name = "Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "수량";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "가격";
            this.Price.Name = "Price";
            // 
            // Cart_lbl
            // 
            this.Cart_lbl.AutoSize = true;
            this.Cart_lbl.Location = new System.Drawing.Point(23, 44);
            this.Cart_lbl.Name = "Cart_lbl";
            this.Cart_lbl.Size = new System.Drawing.Size(65, 19);
            this.Cart_lbl.TabIndex = 1;
            this.Cart_lbl.Text = "장바구니";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(23, 738);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(113, 78);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "뒤로가기";
            // 
            // cash_btn
            // 
            this.cash_btn.Location = new System.Drawing.Point(232, 738);
            this.cash_btn.Name = "cash_btn";
            this.cash_btn.Size = new System.Drawing.Size(113, 78);
            this.cash_btn.TabIndex = 3;
            this.cash_btn.Text = "현금";
            // 
            // card_btn
            // 
            this.card_btn.Location = new System.Drawing.Point(448, 738);
            this.card_btn.Name = "card_btn";
            this.card_btn.Size = new System.Drawing.Size(113, 78);
            this.card_btn.TabIndex = 4;
            this.card_btn.Text = "신용카드";
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.card_btn);
            this.Controls.Add(this.cash_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Cart_lbl);
            this.Controls.Add(this.dataGridView1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private MetroFramework.Controls.MetroLabel Cart_lbl;
        private MetroFramework.Controls.MetroButton back_btn;
        private MetroFramework.Controls.MetroButton cash_btn;
        private MetroFramework.Controls.MetroButton card_btn;
    }
}