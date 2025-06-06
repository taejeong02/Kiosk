namespace KioskProject
{
    partial class MenuOption
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
            this.btnmius = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaze = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmius
            // 
            this.btnmius.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnmius.Location = new System.Drawing.Point(462, 514);
            this.btnmius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmius.Name = "btnmius";
            this.btnmius.Size = new System.Drawing.Size(46, 39);
            this.btnmius.TabIndex = 26;
            this.btnmius.Text = "-";
            this.btnmius.UseVisualStyleBackColor = true;
            this.btnmius.Click += new System.EventHandler(this.btnmius_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnplus.Location = new System.Drawing.Point(364, 514);
            this.btnplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(46, 39);
            this.btnplus.TabIndex = 25;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblQuantity.Location = new System.Drawing.Point(424, 526);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(20, 19);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrice.Location = new System.Drawing.Point(416, 599);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 22);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(71, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "주문금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(70, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "수량";
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(420, 349);
            this.btnFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(88, 74);
            this.btnFour.TabIndex = 19;
            this.btnFour.Text = "엄청매운맛";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(303, 349);
            this.btnThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(88, 74);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "매운맛";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(186, 349);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(88, 74);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "보통맛";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(78, 349);
            this.btnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(88, 74);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "순한맛";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(50, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "맵기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(365, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "곱빼기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(152, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "기본";
            // 
            // btnLaze
            // 
            this.btnLaze.Location = new System.Drawing.Point(337, 88);
            this.btnLaze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaze.Name = "btnLaze";
            this.btnLaze.Size = new System.Drawing.Size(122, 112);
            this.btnLaze.TabIndex = 12;
            this.btnLaze.Text = "button3";
            this.btnLaze.UseVisualStyleBackColor = true;
            this.btnLaze.Click += new System.EventHandler(this.btnLaze_Click_1);
            // 
            // btnMiddle
            // 
            this.btnMiddle.Location = new System.Drawing.Point(115, 88);
            this.btnMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(122, 112);
            this.btnMiddle.TabIndex = 11;
            this.btnMiddle.Text = "button2";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click_1);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(67, 706);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(449, 62);
            this.btnAddCart.TabIndex = 10;
            this.btnAddCart.Text = "장바구니 추가";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuName.Location = new System.Drawing.Point(35, 28);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(114, 32);
            this.lblMenuName.TabIndex = 27;
            this.lblMenuName.Text = "음식이름";
            // 
            // MenuOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.btnmius);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLaze);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnAddCart);
            this.Name = "MenuOption";
            this.Text = "MenuOption";
            this.Load += new System.EventHandler(this.MenuOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmius;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaze;
        private System.Windows.Forms.Button btnMiddle;
        public System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblMenuName;
    }
}