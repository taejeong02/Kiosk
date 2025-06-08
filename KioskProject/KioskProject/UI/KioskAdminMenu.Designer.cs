using System.Drawing;
using System.Windows.Forms;

namespace KioskProject
{
    partial class KioskAdminMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Num_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Category_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Delmenu_btn = new System.Windows.Forms.Button();
            this.Modify_btn = new System.Windows.Forms.Button();
            this.Addmenu_btn = new System.Windows.Forms.Button();
            this.F5_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Menu_gridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Spicy_checkbox = new System.Windows.Forms.CheckBox();
            this.Size_checkbox = new System.Windows.Forms.CheckBox();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자 메뉴 관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(436, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "상품명 입력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(451, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "상품 번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(455, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "상품명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(456, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "상품가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(436, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "상품 카테고리";
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(432, 47);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(114, 21);
            this.Search_txt.TabIndex = 6;
            // 
            // Num_txt
            // 
            this.Num_txt.Location = new System.Drawing.Point(432, 175);
            this.Num_txt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Num_txt.Name = "Num_txt";
            this.Num_txt.Size = new System.Drawing.Size(113, 21);
            this.Num_txt.TabIndex = 7;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(431, 227);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(113, 21);
            this.Name_txt.TabIndex = 8;
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(431, 289);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(113, 21);
            this.Price_txt.TabIndex = 9;
            // 
            // Category_txt
            // 
            this.Category_txt.Location = new System.Drawing.Point(431, 353);
            this.Category_txt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Category_txt.Name = "Category_txt";
            this.Category_txt.Size = new System.Drawing.Size(113, 21);
            this.Category_txt.TabIndex = 10;
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_btn.Location = new System.Drawing.Point(432, 81);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(112, 33);
            this.Search_btn.TabIndex = 11;
            this.Search_btn.Text = "상품 검색";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Delmenu_btn
            // 
            this.Delmenu_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delmenu_btn.Location = new System.Drawing.Point(428, 630);
            this.Delmenu_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Delmenu_btn.Name = "Delmenu_btn";
            this.Delmenu_btn.Size = new System.Drawing.Size(112, 33);
            this.Delmenu_btn.TabIndex = 12;
            this.Delmenu_btn.Text = "메뉴 삭제";
            this.Delmenu_btn.UseVisualStyleBackColor = true;
            this.Delmenu_btn.Click += new System.EventHandler(this.Delmenu_btn_Click);
            // 
            // Modify_btn
            // 
            this.Modify_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Modify_btn.Location = new System.Drawing.Point(428, 728);
            this.Modify_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(112, 33);
            this.Modify_btn.TabIndex = 13;
            this.Modify_btn.Text = "메뉴 수정";
            this.Modify_btn.UseVisualStyleBackColor = true;
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // Addmenu_btn
            // 
            this.Addmenu_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Addmenu_btn.Location = new System.Drawing.Point(428, 584);
            this.Addmenu_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Addmenu_btn.Name = "Addmenu_btn";
            this.Addmenu_btn.Size = new System.Drawing.Size(112, 33);
            this.Addmenu_btn.TabIndex = 14;
            this.Addmenu_btn.Text = "메뉴 추가";
            this.Addmenu_btn.UseVisualStyleBackColor = true;
            this.Addmenu_btn.Click += new System.EventHandler(this.Addmenu_btn_Click);
            // 
            // F5_btn
            // 
            this.F5_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.F5_btn.Location = new System.Drawing.Point(427, 677);
            this.F5_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.F5_btn.Name = "F5_btn";
            this.F5_btn.Size = new System.Drawing.Size(112, 33);
            this.F5_btn.TabIndex = 15;
            this.F5_btn.Text = "새로 고침";
            this.F5_btn.UseVisualStyleBackColor = true;
            this.F5_btn.Click += new System.EventHandler(this.F5_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Back_btn.Location = new System.Drawing.Point(428, 777);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(112, 33);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "뒤로 가기";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Menu_gridview
            // 
            this.Menu_gridview.AllowUserToAddRows = false;
            this.Menu_gridview.AllowUserToDeleteRows = false;
            this.Menu_gridview.AllowUserToResizeColumns = false;
            this.Menu_gridview.AllowUserToResizeRows = false;
            this.Menu_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Menu_gridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.ColProductName,
            this.ColProductPrice,
            this.ColProductCategory});
            this.Menu_gridview.Location = new System.Drawing.Point(15, 47);
            this.Menu_gridview.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Menu_gridview.MultiSelect = false;
            this.Menu_gridview.Name = "Menu_gridview";
            this.Menu_gridview.ReadOnly = true;
            this.Menu_gridview.RowHeadersVisible = false;
            this.Menu_gridview.RowHeadersWidth = 62;
            this.Menu_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Menu_gridview.Size = new System.Drawing.Size(374, 763);
            this.Menu_gridview.TabIndex = 17;
            this.Menu_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_gridview_CellClick);
            this.Menu_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_gridview_CellContentClick);
            this.Menu_gridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_gridview_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(428, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "사진추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UploadImage_btn_Click);
            // 
            // Spicy_checkbox
            // 
            this.Spicy_checkbox.AutoSize = true;
            this.Spicy_checkbox.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Spicy_checkbox.Location = new System.Drawing.Point(440, 402);
            this.Spicy_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Spicy_checkbox.Name = "Spicy_checkbox";
            this.Spicy_checkbox.Size = new System.Drawing.Size(93, 24);
            this.Spicy_checkbox.TabIndex = 21;
            this.Spicy_checkbox.Text = "맵기 선택";
            this.Spicy_checkbox.UseVisualStyleBackColor = true;
            this.Spicy_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Size_checkbox
            // 
            this.Size_checkbox.AutoSize = true;
            this.Size_checkbox.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Size_checkbox.Location = new System.Drawing.Point(431, 444);
            this.Size_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Size_checkbox.Name = "Size_checkbox";
            this.Size_checkbox.Size = new System.Drawing.Size(108, 24);
            this.Size_checkbox.TabIndex = 22;
            this.Size_checkbox.Text = "사이즈 선택";
            this.Size_checkbox.UseVisualStyleBackColor = true;
            this.Size_checkbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ColProductID
            // 
            this.ColProductID.DataPropertyName = "ProductID";
            this.ColProductID.HeaderText = "상품 번호";
            this.ColProductID.MinimumWidth = 8;
            this.ColProductID.Name = "ColProductID";
            this.ColProductID.ReadOnly = true;
            // 
            // ColProductName
            // 
            this.ColProductName.DataPropertyName = "ProductName";
            this.ColProductName.HeaderText = "상품명";
            this.ColProductName.MinimumWidth = 8;
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColProductPrice
            // 
            this.ColProductPrice.DataPropertyName = "ProductPrice";
            this.ColProductPrice.HeaderText = "상품가격";
            this.ColProductPrice.MinimumWidth = 8;
            this.ColProductPrice.Name = "ColProductPrice";
            this.ColProductPrice.ReadOnly = true;
            // 
            // ColProductCategory
            // 
            this.ColProductCategory.DataPropertyName = "ProductCategory";
            this.ColProductCategory.HeaderText = "카테고리";
            this.ColProductCategory.MinimumWidth = 8;
            this.ColProductCategory.Name = "ColProductCategory";
            this.ColProductCategory.ReadOnly = true;
            // 
            // KioskAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.ControlBox = false;
            this.Controls.Add(this.Size_checkbox);
            this.Controls.Add(this.Spicy_checkbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Menu_gridview);
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
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "KioskAdminMenu";
            this.Text = "키오스크 관리자 메뉴 화면";
            this.Load += new System.EventHandler(this.KioskAdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Search_txt;
        private TextBox Num_txt;
        private TextBox Name_txt;
        private TextBox Price_txt;
        private TextBox Category_txt;
        private Button Search_btn;
        private Button Delmenu_btn;
        private Button Modify_btn;
        private Button Addmenu_btn;
        private Button F5_btn;
        private Button Back_btn;
        private DataGridView Menu_gridview;
        private Button button1;
        private CheckBox Spicy_checkbox;
        private CheckBox Size_checkbox;
        private DataGridViewTextBoxColumn ColProductID;
        private DataGridViewTextBoxColumn ColProductName;
        private DataGridViewTextBoxColumn ColProductPrice;
        private DataGridViewTextBoxColumn ColProductCategory;
    }
}