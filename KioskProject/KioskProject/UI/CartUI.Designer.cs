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
            this.productNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cart = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.cashbtn = new System.Windows.Forms.Button();
            this.cardbtn = new System.Windows.Forms.Button();
            this.Plusbtn = new System.Windows.Forms.Button();
            this.Miusbtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNum,
            this.productName,
            this.Qty,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(33, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(784, 742);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productNum
            // 
            this.productNum.HeaderText = "상품 번호";
            this.productNum.MinimumWidth = 8;
            this.productNum.Name = "productNum";
            // 
            // productName
            // 
            this.productName.HeaderText = "상품명";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "상품 수량";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            // 
            // Price
            // 
            this.Price.HeaderText = "상품 가격";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltotal.Location = new System.Drawing.Point(337, 936);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(217, 40);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "총 결제 금액 : ";
            // 
            // cart
            // 
            this.cart.AutoSize = true;
            this.cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cart.Location = new System.Drawing.Point(49, 75);
            this.cart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(133, 40);
            this.cart.TabIndex = 1;
            this.cart.Text = "장바구니";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(56, 1035);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(226, 280);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "뒤로가기";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // cashbtn
            // 
            this.cashbtn.Location = new System.Drawing.Point(344, 1035);
            this.cashbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cashbtn.Name = "cashbtn";
            this.cashbtn.Size = new System.Drawing.Size(226, 280);
            this.cashbtn.TabIndex = 2;
            this.cashbtn.Text = "현금결제";
            this.cashbtn.UseVisualStyleBackColor = true;
            this.cashbtn.Click += new System.EventHandler(this.cashbtn_Click);
            // 
            // cardbtn
            // 
            this.cardbtn.Location = new System.Drawing.Point(591, 1035);
            this.cardbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cardbtn.Name = "cardbtn";
            this.cardbtn.Size = new System.Drawing.Size(226, 280);
            this.cardbtn.TabIndex = 2;
            this.cardbtn.Text = "카드결제";
            this.cardbtn.UseVisualStyleBackColor = true;
            this.cardbtn.Click += new System.EventHandler(this.cardbtn_Click);
            // 
            // Plusbtn
            // 
            this.Plusbtn.Location = new System.Drawing.Point(56, 915);
            this.Plusbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Plusbtn.Name = "Plusbtn";
            this.Plusbtn.Size = new System.Drawing.Size(107, 90);
            this.Plusbtn.TabIndex = 3;
            this.Plusbtn.Text = "+";
            this.Plusbtn.UseVisualStyleBackColor = true;
            this.Plusbtn.Click += new System.EventHandler(this.Plusbtn_Click);
            // 
            // Miusbtn
            // 
            this.Miusbtn.Location = new System.Drawing.Point(174, 915);
            this.Miusbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Miusbtn.Name = "Miusbtn";
            this.Miusbtn.Size = new System.Drawing.Size(107, 90);
            this.Miusbtn.TabIndex = 3;
            this.Miusbtn.Text = "-";
            this.Miusbtn.UseVisualStyleBackColor = true;
            this.Miusbtn.Click += new System.EventHandler(this.Miusbtn_Click);
            // 
            // Timer
            // 
            this.Timer.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Timer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Timer.Location = new System.Drawing.Point(541, 75);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(276, 40);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "120";
            this.Timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 1350);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Miusbtn);
            this.Controls.Add(this.Plusbtn);
            this.Controls.Add(this.cardbtn);
            this.Controls.Add(this.cashbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartUI";
            this.Padding = new System.Windows.Forms.Padding(29, 90, 29, 30);
            this.Load += new System.EventHandler(this.CartUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label cart;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button cashbtn;
        private System.Windows.Forms.Button cardbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button Plusbtn;
        private System.Windows.Forms.Button Miusbtn;
        private System.Windows.Forms.Label Timer;
    }
}