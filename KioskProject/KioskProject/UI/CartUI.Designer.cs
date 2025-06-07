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
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.cash_btn = new MetroFramework.Controls.MetroButton();
            this.card_btn = new MetroFramework.Controls.MetroButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.Cart_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(23, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(538, 502);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(40, 678);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(118, 149);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "뒤로가기";
            // 
            // cash_btn
            // 
            this.cash_btn.Location = new System.Drawing.Point(290, 678);
            this.cash_btn.Name = "cash_btn";
            this.cash_btn.Size = new System.Drawing.Size(114, 149);
            this.cash_btn.TabIndex = 3;
            this.cash_btn.Text = "현금";
            // 
            // card_btn
            // 
            this.card_btn.Location = new System.Drawing.Point(436, 678);
            this.card_btn.Name = "card_btn";
            this.card_btn.Size = new System.Drawing.Size(109, 149);
            this.card_btn.TabIndex = 4;
            this.card_btn.Text = "신용카드";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AllowDrop = true;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPrice.Location = new System.Drawing.Point(142, 622);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(132, 23);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "총 결제 금액  : ";
            // 
            // Cart_lbl
            // 
            this.Cart_lbl.AutoSize = true;
            this.Cart_lbl.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cart_lbl.Location = new System.Drawing.Point(23, 27);
            this.Cart_lbl.Name = "Cart_lbl";
            this.Cart_lbl.Size = new System.Drawing.Size(114, 32);
            this.Cart_lbl.TabIndex = 9;
            this.Cart_lbl.Text = "장바구니";
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.Cart_lbl);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.card_btn);
            this.Controls.Add(this.cash_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CartUI";
            this.Load += new System.EventHandler(this.CartUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton back_btn;
        private MetroFramework.Controls.MetroButton cash_btn;
        private MetroFramework.Controls.MetroButton card_btn;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label Cart_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}