using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject.UI
{

    public partial class KioskAdminMenu: Form
    {
        public class FoodItem
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public string ProductPrice { get; set; }
            public string ProductCategory { get; set; }
            public int IsSpicyOptionEnabled { get; set; }
            public int IsSizeOptionEnabled { get; set; }

        }

        private List<FoodItem> foodItems = new List<FoodItem>();

        private string connectionString = "server=34.45.48.0;database=Kiosk;uid=appuser;pwd=KioskProjectghguddeumk2";


        public KioskAdminMenu()
        {
            InitializeComponent();
        }

        private void KioskAdminMenu_Load(object sender, EventArgs e)
        {
            Menu_gridview.AutoGenerateColumns = false;



            Menu_gridview.Columns.Clear();

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "ProductID";
            col1.HeaderText = "상품번호";
            col1.DataPropertyName = "ProductID";
            Menu_gridview.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "ProductName";
            col2.HeaderText = "상품명";
            col2.DataPropertyName = "ProductName";
            Menu_gridview.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "ProductPrice";
            col3.HeaderText = "상품가격";
            col3.DataPropertyName = "ProductPrice";
            Menu_gridview.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "ProductCategory";
            col4.HeaderText = "상품카테고리";
            col4.DataPropertyName = "ProductCategory";
            Menu_gridview.Columns.Add(col4);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "ProductImage";
            imageColumn.HeaderText = "이미지";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Width = 60; // 썸네일 크기 조절
            Menu_gridview.Columns.Add(imageColumn);

            DataGridViewCheckBoxColumn spicyCol = new DataGridViewCheckBoxColumn();
            spicyCol.Name = "IsSpicyOptionEnabled";
            spicyCol.HeaderText = "맵기선택";
            spicyCol.DataPropertyName = "IsSpicyOptionEnabled";
            spicyCol.Width = 60;
            Menu_gridview.Columns.Add(spicyCol);

            DataGridViewCheckBoxColumn sizeCol = new DataGridViewCheckBoxColumn();
            sizeCol.Name = "IsSizeOptionEnabled";
            sizeCol.HeaderText = "사이즈선택";
            sizeCol.DataPropertyName = "IsSizeOptionEnabled";
            sizeCol.Width = 60;
            Menu_gridview.Columns.Add(sizeCol);

            // 데이터 바인딩
            DisplayMenuList();

            // 열 크기 조정
            Menu_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Menu_gridview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }
        private bool ValidateInput(string id, string name, string price, string category, bool isModify = false)
        {
            //상품번호 입력 검사
            if (string.IsNullOrWhiteSpace(id))
            {
                ShowMessage("상품번호를 입력해주세요.");
                return false;
            }
            if (!Regex.IsMatch(id, @"^\d{1,10}$"))
            {
                ShowMessage("올바른 상품번호를 작성해주세요 (문자, 특수기호, 공백 금지, 10자 이내)");
                return false;
            }
            if (!isModify && foodItems.Any(item => item.ProductID == id))
            {
                ShowMessage("중복된 상품번호입니다. 다른 번호를 입력해주세요.");
                return false;
            }

            //상품명 입력 검사
            if (string.IsNullOrWhiteSpace(name))
            {
                ShowMessage("상품명을 입력해주세요.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^[가-힣a-zA-Z\s]{1,100}$"))
            {
                ShowMessage("올바른 상품명을 작성해주세요 (숫자, 특수 기호 금지, 100자 이내)");
                return false;
            }

            //상품가격 입력 검사
            if (string.IsNullOrWhiteSpace(price))
            {
                ShowMessage("상품가격을 입력해주세요.");
                return false;
            }
            if (!Regex.IsMatch(price, @"^\d{1,10}$"))
            {
                ShowMessage("올바른 상품가격을 작성해주세요 (문자, 특수기호 금지, 10자 이내)");
                return false;
            }

            //상품카테고리 입력 검사
            if (string.IsNullOrWhiteSpace(category))
            {
                ShowMessage("상품카테고리를 입력해주세요.");
                return false;
            }
            if (!Regex.IsMatch(category, @"^[가-힣a-zA-Z]{1,50}$"))
            {
                ShowMessage("올바른 상품카테고리를 작성해주세요 (공백, 숫자, 특수 기호 금지, 50자 이내)");
                return false;
            }

            return true;
        }

        private bool IsDuplicate(string name)
        {
            return foodItems.Exists(item => item.ProductName == name);
        }

        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void DisplayMenuList()
        {
            foodItems.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM menu ORDER BY CAST(ProductID AS UNSIGNED)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    foodItems.Add(new FoodItem
                    {
                        ProductID = reader["ProductID"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        ProductPrice = reader["ProductPrice"].ToString(),
                        ProductCategory = reader["ProductCategory"].ToString(),
                        IsSpicyOptionEnabled = Convert.ToInt32(reader["IsSpicyOptionEnabled"]),
                        IsSizeOptionEnabled = Convert.ToInt32(reader["IsSizeOptionEnabled"])
                    });
                }
            }

            Menu_gridview.DataSource = null;
            Menu_gridview.DataSource = foodItems;
            // 각 행에 따른 상품번호 이미지 로드
            for (int i = 0; i < Menu_gridview.Rows.Count; i++)
            {
                string productId = Menu_gridview.Rows[i].Cells["ProductID"].Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "MenuImages", productId + ".jpg");

                if (File.Exists(imagePath))
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        using (Image original = Image.FromStream(fs))
                        {
                            // Bitmap을 따로 복사해서 리소스 독립
                            Bitmap thumb = new Bitmap(original, new Size(50, 50));
                            Menu_gridview.Rows[i].Cells["ProductImage"].Value = (Image)thumb.Clone();
                            thumb.Dispose(); // 원본은 바로 폐기
                        }
                    }
                }
                else
                {
                    Bitmap blank = new Bitmap(50, 50);
                    using (Graphics g = Graphics.FromImage(blank))
                    {
                        g.Clear(Color.LightGray);
                    }
                    Menu_gridview.Rows[i].Cells["ProductImage"].Value = blank;
                }
            }
        }


        //행 클릭 시 텍스트 박스 자동 채우기 함수
        private void Menu_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // 빈 공간 클릭 시 입력값 초기화
        private void Menu_gridview_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private bool IsInputEmpty()
        {
            return string.IsNullOrWhiteSpace(Num_txt.Text) &&
                   string.IsNullOrWhiteSpace(Num_txt.Text) &&
                   string.IsNullOrWhiteSpace(Num_txt.Text) &&
                   string.IsNullOrWhiteSpace(Num_txt.Text);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }


        private void Addmenu_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delmenu_btn_Click(object sender, EventArgs e)
        {

        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {

        }

        private void F5_btn_Click(object sender, EventArgs e)
        {
            DisplayMenuList();
        }

        //사용자가 선택한 이미지를 상품번호로 저장
        private void SaveMenuImage(string productId)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                // 사용자가 파일을 선택했을 때
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;

                    // 이미지 저장 폴더 경로 설정프로그램 실행 경로 기준
                    string imageDir = Path.Combine(Application.StartupPath, "MenuImages");
                    Directory.CreateDirectory(imageDir); // 폴더 없으면 생성

                    string destPath = Path.Combine(imageDir, productId + ".jpg");

                    // 원본 이미지를 지정 크기로 리사이즈 후 저장
                    Image original = Image.FromFile(sourcePath);
                    Image resized = ResizeImage(original, 180, 120);
                    resized.Save(destPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                    //완료 알림
                    MessageBox.Show("사진이 저장되었습니다.");
                }
            }
        }

        //이미지를 지정된 크기로 재지정
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }


        //이미지 추가 버튼
        private void UploadImage_btn_Click(object sender, EventArgs e)
        {

        }

        private void Menu_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
