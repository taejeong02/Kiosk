namespace KioskProject
{
    partial class OrderUI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrink = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.count = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.btnNoodles = new MetroFramework.Controls.MetroButton();
            this.btnRice = new MetroFramework.Controls.MetroButton();
            this.btnSide = new MetroFramework.Controls.MetroButton();
            this.btnAlcohol = new MetroFramework.Controls.MetroButton();
            this.btnsuggestion = new MetroFramework.Controls.MetroButton();
            this.btnSetmenu = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 349);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(427, 39);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(80, 60);
            this.btnDrink.TabIndex = 4;
            this.btnDrink.Text = "주류";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(400, 640);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 44);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(34, 567);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 268);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(380, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "선택한 상품 : ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.count.Location = new System.Drawing.Point(488, 577);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(62, 24);
            this.count.TabIndex = 12;
            this.count.Text = "count";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 140);
            this.button1.TabIndex = 13;
            this.button1.Text = "장바구니";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNoodles
            // 
            this.btnNoodles.Location = new System.Drawing.Point(66, 39);
            this.btnNoodles.Name = "btnNoodles";
            this.btnNoodles.Size = new System.Drawing.Size(80, 60);
            this.btnNoodles.TabIndex = 1;
            this.btnNoodles.Text = "면류";
            this.btnNoodles.UseVisualStyleBackColor = true;
            this.btnNoodles.Click += new System.EventHandler(this.btnNoodles_Click);
            // 
            // btnRice
            // 
            this.btnRice.Location = new System.Drawing.Point(184, 39);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(80, 60);
            this.btnRice.TabIndex = 2;
            this.btnRice.Text = "밥류";
            this.btnRice.UseVisualStyleBackColor = true;
            this.btnRice.Click += new System.EventHandler(this.btnRice_Click);
            // 
            // btnSide
            // 
            this.btnSide.Location = new System.Drawing.Point(310, 39);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(80, 60);
            this.btnSide.TabIndex = 3;
            this.btnSide.Text = "사이드메뉴";
            this.btnSide.UseVisualStyleBackColor = true;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnAlcohol
            // 
            this.btnAlcohol.Location = new System.Drawing.Point(131, 116);
            this.btnAlcohol.Name = "btnAlcohol";
            this.btnAlcohol.Size = new System.Drawing.Size(80, 60);
            this.btnAlcohol.TabIndex = 5;
            this.btnAlcohol.Text = "음료류";
            this.btnAlcohol.UseVisualStyleBackColor = true;
            this.btnAlcohol.Click += new System.EventHandler(this.btnAlcohol_Click);
            // 
            // btnsuggestion
            // 
            this.btnsuggestion.Location = new System.Drawing.Point(253, 116);
            this.btnsuggestion.Name = "btnsuggestion";
            this.btnsuggestion.Size = new System.Drawing.Size(80, 60);
            this.btnsuggestion.TabIndex = 8;
            this.btnsuggestion.Text = "추천메뉴";
            this.btnsuggestion.UseVisualStyleBackColor = true;
            this.btnsuggestion.Click += new System.EventHandler(this.btnsuggestion_Click);
            // 
            // btnSetmenu
            // 
            this.btnSetmenu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetmenu.Location = new System.Drawing.Point(363, 116);
            this.btnSetmenu.Name = "btnSetmenu";
            this.btnSetmenu.Size = new System.Drawing.Size(80, 60);
            this.btnSetmenu.TabIndex = 9;
            this.btnSetmenu.Text = "세트메뉴";
            this.btnSetmenu.UseVisualStyleBackColor = true;
            this.btnSetmenu.Click += new System.EventHandler(this.btnSetmenu_Click);
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSetmenu);
            this.Controls.Add(this.btnsuggestion);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAlcohol);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnSide);
            this.Controls.Add(this.btnRice);
            this.Controls.Add(this.btnNoodles);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderUI";
            this.Load += new System.EventHandler(this.OrderUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnDrink;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel count;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton btnNoodles;
        private MetroFramework.Controls.MetroButton btnRice;
        private MetroFramework.Controls.MetroButton btnSide;
        private MetroFramework.Controls.MetroButton btnAlcohol;
        private MetroFramework.Controls.MetroButton btnsuggestion;
        private MetroFramework.Controls.MetroButton btnSetmenu;
    }
}

