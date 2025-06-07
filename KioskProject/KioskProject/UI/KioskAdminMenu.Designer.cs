namespace KioskProject.UI
{
    partial class KioskAdminMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_gridview = new System.Windows.Forms.DataGridView();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size_checkbox = new System.Windows.Forms.CheckBox();
            this.Spicy_checkbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.F5_btn = new System.Windows.Forms.Button();
            this.Addmenu_btn = new System.Windows.Forms.Button();
            this.Modify_btn = new System.Windows.Forms.Button();
            this.Delmenu_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Category_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Num_txt = new System.Windows.Forms.TextBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자 메뉴 관리";
            // 
            // Menu_gridview
            // 
            this.Menu_gridview.AllowUserToAddRows = false;
            this.Menu_gridview.AllowUserToDeleteRows = false;
            this.Menu_gridview.AllowUserToResizeColumns = false;
            this.Menu_gridview.AllowUserToResizeRows = false;
            this.Menu_gridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.ColProductName,
            this.ColProductPrice,
            this.ColProductCategory});
            this.Menu_gridview.Location = new System.Drawing.Point(21, 71);
            this.Menu_gridview.Margin = new System.Windows.Forms.Padding(2);
            this.Menu_gridview.MultiSelect = false;
            this.Menu_gridview.Name = "Menu_gridview";
            this.Menu_gridview.ReadOnly = true;
            this.Menu_gridview.RowHeadersVisible = false;
            this.Menu_gridview.RowHeadersWidth = 62;
            this.Menu_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Menu_gridview.Size = new System.Drawing.Size(535, 1145);
            this.Menu_gridview.TabIndex = 18;
            this.Menu_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_gridview_CellClick);
            this.Menu_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_gridview_CellContentClick);
            // 
            // ColProductID
            // 
            this.ColProductID.DataPropertyName = "ProductID";
            this.ColProductID.HeaderText = "상품 번호";
            this.ColProductID.MinimumWidth = 8;
            this.ColProductID.Name = "ColProductID";
            this.ColProductID.ReadOnly = true;
            this.ColProductID.Width = 150;
            // 
            // ColProductName
            // 
            this.ColProductName.DataPropertyName = "ProductName";
            this.ColProductName.HeaderText = "상품명";
            this.ColProductName.MinimumWidth = 8;
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            this.ColProductName.Width = 150;
            // 
            // ColProductPrice
            // 
            this.ColProductPrice.DataPropertyName = "ProductPrice";
            this.ColProductPrice.HeaderText = "상품가격";
            this.ColProductPrice.MinimumWidth = 8;
            this.ColProductPrice.Name = "ColProductPrice";
            this.ColProductPrice.ReadOnly = true;
            this.ColProductPrice.Width = 150;
            // 
            // ColProductCategory
            // 
            this.ColProductCategory.DataPropertyName = "ProductCategory";
            this.ColProductCategory.HeaderText = "상품카테고리";
            this.ColProductCategory.MinimumWidth = 8;
            this.ColProductCategory.Name = "ColProductCategory";
            this.ColProductCategory.ReadOnly = true;
            this.ColProductCategory.Width = 150;
            // 
            // Size_checkbox
            // 
            this.Size_checkbox.AutoSize = true;
            this.Size_checkbox.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Size_checkbox.Location = new System.Drawing.Point(583, 633);
            this.Size_checkbox.Name = "Size_checkbox";
            this.Size_checkbox.Size = new System.Drawing.Size(157, 34);
            this.Size_checkbox.TabIndex = 41;
            this.Size_checkbox.Text = "사이즈 선택";
            this.Size_checkbox.UseVisualStyleBackColor = true;
            this.Size_checkbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Spicy_checkbox
            // 
            this.Spicy_checkbox.AutoSize = true;
            this.Spicy_checkbox.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Spicy_checkbox.Location = new System.Drawing.Point(594, 575);
            this.Spicy_checkbox.Name = "Spicy_checkbox";
            this.Spicy_checkbox.Size = new System.Drawing.Size(135, 34);
            this.Spicy_checkbox.TabIndex = 40;
            this.Spicy_checkbox.Text = "맵기 선택";
            this.Spicy_checkbox.UseVisualStyleBackColor = true;
            this.Spicy_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(580, 844);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 39;
            this.button1.Text = "사진추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UploadImage_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Back_btn.Location = new System.Drawing.Point(580, 1167);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(160, 50);
            this.Back_btn.TabIndex = 38;
            this.Back_btn.Text = "뒤로 가기";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // F5_btn
            // 
            this.F5_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.F5_btn.Location = new System.Drawing.Point(580, 1038);
            this.F5_btn.Margin = new System.Windows.Forms.Padding(2);
            this.F5_btn.Name = "F5_btn";
            this.F5_btn.Size = new System.Drawing.Size(160, 50);
            this.F5_btn.TabIndex = 37;
            this.F5_btn.Text = "새로 고침";
            this.F5_btn.UseVisualStyleBackColor = true;
            this.F5_btn.Click += new System.EventHandler(this.F5_btn_Click);
            // 
            // Addmenu_btn
            // 
            this.Addmenu_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Addmenu_btn.Location = new System.Drawing.Point(579, 909);
            this.Addmenu_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Addmenu_btn.Name = "Addmenu_btn";
            this.Addmenu_btn.Size = new System.Drawing.Size(160, 50);
            this.Addmenu_btn.TabIndex = 36;
            this.Addmenu_btn.Text = "메뉴 추가";
            this.Addmenu_btn.UseVisualStyleBackColor = true;
            this.Addmenu_btn.Click += new System.EventHandler(this.Addmenu_btn_Click);
            // 
            // Modify_btn
            // 
            this.Modify_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Modify_btn.Location = new System.Drawing.Point(580, 1103);
            this.Modify_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(160, 50);
            this.Modify_btn.TabIndex = 35;
            this.Modify_btn.Text = "메뉴 수정";
            this.Modify_btn.UseVisualStyleBackColor = true;
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // Delmenu_btn
            // 
            this.Delmenu_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delmenu_btn.Location = new System.Drawing.Point(579, 974);
            this.Delmenu_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delmenu_btn.Name = "Delmenu_btn";
            this.Delmenu_btn.Size = new System.Drawing.Size(160, 50);
            this.Delmenu_btn.TabIndex = 34;
            this.Delmenu_btn.Text = "메뉴 삭제";
            this.Delmenu_btn.UseVisualStyleBackColor = true;
            this.Delmenu_btn.Click += new System.EventHandler(this.Delmenu_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_btn.Location = new System.Drawing.Point(577, 106);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(160, 50);
            this.Search_btn.TabIndex = 33;
            this.Search_btn.Text = "상품 검색";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Category_txt
            // 
            this.Category_txt.Location = new System.Drawing.Point(577, 515);
            this.Category_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Category_txt.Name = "Category_txt";
            this.Category_txt.Size = new System.Drawing.Size(160, 28);
            this.Category_txt.TabIndex = 32;
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(577, 418);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(160, 28);
            this.Price_txt.TabIndex = 31;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(577, 326);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(160, 28);
            this.Name_txt.TabIndex = 30;
            // 
            // Num_txt
            // 
            this.Num_txt.Location = new System.Drawing.Point(579, 246);
            this.Num_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Num_txt.Name = "Num_txt";
            this.Num_txt.Size = new System.Drawing.Size(160, 28);
            this.Num_txt.TabIndex = 29;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(583, 56);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(161, 28);
            this.Search_txt.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(589, 474);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "상품 카테고리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(612, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "상품가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(623, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "상품명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(612, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "상품 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(602, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "상품명 입력";
            // 
            // KioskAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 1244);
            this.Controls.Add(this.Size_checkbox);
            this.Controls.Add(this.Spicy_checkbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.F5_btn);
            this.Controls.Add(this.Addmenu_btn);
            this.Controls.Add(this.Modify_btn);
            this.Controls.Add(this.Delmenu_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Category_txt);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Num_txt);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menu_gridview);
            this.Controls.Add(this.label1);
            this.Name = "KioskAdminMenu";
            this.Text = "키오스크 관리자 메뉴 화면";
            this.Load += new System.EventHandler(this.KioskAdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Menu_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductCategory;
        private System.Windows.Forms.CheckBox Size_checkbox;
        private System.Windows.Forms.CheckBox Spicy_checkbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button F5_btn;
        private System.Windows.Forms.Button Addmenu_btn;
        private System.Windows.Forms.Button Modify_btn;
        private System.Windows.Forms.Button Delmenu_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Category_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Num_txt;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}