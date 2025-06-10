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

namespace KioskProject
{
    public partial class KioskAdminMenu : MetroFramework.Forms.MetroForm
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
            KioskProject.entity.MenuDB db = new KioskProject.entity.MenuDB();
            foodItems = db.SelectAll();

            Menu_gridview.DataSource = null;
            Menu_gridview.DataSource = foodItems;

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Menu_gridview.Rows[e.RowIndex];

                Num_txt.Text = row.Cells["ProductID"].Value.ToString();
                Name_txt.Text = row.Cells["ProductName"].Value.ToString();
                Price_txt.Text = row.Cells["ProductPrice"].Value.ToString();
                Category_txt.Text = row.Cells["ProductCategory"].Value.ToString();

                //체크박스
                int spicy = Convert.ToInt32(row.Cells["IsSpicyOptionEnabled"].Value ?? 0);
                int size = Convert.ToInt32(row.Cells["IsSizeOptionEnabled"].Value ?? 0);

                Spicy_checkbox.Checked = spicy == 1;
                Size_checkbox.Checked = size == 1;
            }
        }

        // 빈 공간 클릭 시 입력값 초기화
        private void Menu_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = Menu_gridview.HitTest(e.X, e.Y);

            // 클릭한 부분이 셀이 아닌 경우
            if (hit.Type != DataGridViewHitTestType.Cell)
            {
                Num_txt.Text = "";
                Name_txt.Text = "";
                Price_txt.Text = "";
                Category_txt.Text = "";
                Spicy_checkbox.Checked = false;
                Size_checkbox.Checked = false;
            }
        }


        private bool IsInputEmpty()
        {
            return string.IsNullOrWhiteSpace(Num_txt.Text) &&
                   string.IsNullOrWhiteSpace(Num_txt.Text) &&
                   string.IsNullOrWhiteSpace(Num_txt.Text) &&
                   string.IsNullOrWhiteSpace(Num_txt.Text);
        }

        private void Menu_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            //입력 필드에 내용 있는지 확인
            if (!IsInputEmpty() || Spicy_checkbox.Checked || Size_checkbox.Checked)
            {
                ShowMessage("메뉴 추가를 완료하고 종료해주세요");
                return;
            }
            //초기화면 로딩
            foreach (Form form in Application.OpenForms)
            {
                if (form is ShopPacking)
                {
                    form.Show();
                    break;
                }
            }
            //현재 폼 종료
            this.Close();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            //검색어 가져오기
            string keyword = Search_txt.Text.Trim();

            //검색어가 비어있는 경우 전체 표시
            if (string.IsNullOrWhiteSpace(keyword))
            {
                DisplayMenuList();
                return;
            }

            //리스트에서 검색어 포함 항목만 필터링
            List<FoodItem> searchResult = foodItems.FindAll(item =>
            item.ProductName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
            );


            //검색 결과 테이블에 없음
            if (searchResult.Count == 0)
            {
                ShowMessage("검색된 상품이 없습니다.");
                return;
            }

            //검색 결과 테이블에 반영
            Menu_gridview.DataSource = null;
            Menu_gridview.DataSource = searchResult;


            //이미지도 함께 출력
            for (int i = 0; i < Menu_gridview.Rows.Count; i++)
            {
                string productId = Menu_gridview.Rows[i].Cells["ProductID"].Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "MenuImages", productId + ".jpg");

                if (File.Exists(imagePath))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            using (Image original = Image.FromStream(fs))
                            {
                                // 복사본을 만들어 DataGridView에만 사용하고 파일은 닫음
                                Image thumb = new Bitmap(original, new Size(50, 50));
                                Menu_gridview.Rows[i].Cells["ProductImage"].Value = (Image)thumb.Clone();
                                thumb.Dispose();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // 실패 시 기본 회색 이미지 넣기
                        Bitmap blank = new Bitmap(50, 50);
                        using (Graphics g = Graphics.FromImage(blank))
                            g.Clear(Color.LightGray);
                        Menu_gridview.Rows[i].Cells["ProductImage"].Value = blank;
                    }
                }
                else
                {
                    Bitmap blank = new Bitmap(50, 50);
                    using (Graphics g = Graphics.FromImage(blank))
                        g.Clear(Color.LightGray);
                    Menu_gridview.Rows[i].Cells["ProductImage"].Value = blank;
                }
            }
        }
        

        private void Addmenu_btn_Click(object sender, EventArgs e)
        {

            //체크박스 상태 갱신
            this.ActiveControl = null;
            //ID수정 방지 위한 읽기 모드
            Num_txt.ReadOnly = false;

            //입력값 가져오기
            string id = Num_txt.Text.Trim();
            string name = Name_txt.Text.Trim();
            string price = Price_txt.Text.Trim();
            string category = Category_txt.Text.Trim();

            //체크박스 상태 가져오기
            bool isSpicy = Spicy_checkbox.Checked;
            bool isSize = Size_checkbox.Checked;

            //입력값 유효성 검사
            if (!ValidateInput(id, name, price, category))
                return;

            //중복 검사
            if (IsDuplicate(name))
            {
                ShowMessage("이미 등록된 메뉴입니다.");
                return;
            }

            FoodItem newItem = new FoodItem
            {
                ProductID = id,
                ProductName = name,
                ProductPrice = price,
                ProductCategory = category,
                IsSpicyOptionEnabled = isSpicy ? 1 : 0,
                IsSizeOptionEnabled = isSize ? 1 : 0

            };
            foodItems.Add(newItem);
            //DB 저장 로직 
            KioskProject.entity.MenuDB db = new KioskProject.entity.MenuDB();
            db.Insert(newItem);

            //메뉴 추가 성공 메시지 출력
            ShowMessage("메뉴가 등록되었습니다.");

            //입력 필드 초기화
            Num_txt.Text = "";
            Name_txt.Text = "";
            Price_txt.Text = "";
            Category_txt.Text = "";

            // 체크박스 초기화
            Spicy_checkbox.Checked = false;
            Size_checkbox.Checked = false;
        }

        private void Delmenu_btn_Click(object sender, EventArgs e)
        {
            //현재 선택된 행 가져오기
            DataGridViewRow selectedRow = Menu_gridview.CurrentRow;

            //선택된 행이 없는 경우
            if (selectedRow == null)
            {
                ShowMessage("삭제할 항목을 선택해주세요");
                return;
            }

            //선택된 행에서 상품명 가져오기
            string selectedName = selectedRow.Cells["ProductName"].Value.ToString();

            //삭제 확인 메시지
            DialogResult result = MessageBox.Show($"{selectedName}메뉴를 정말 삭제하시겠습니까?", "삭제 확인",
                MessageBoxButtons.YesNo);
            //아니요 누르면 중단
            if (result != DialogResult.Yes)
            {
                return;
            }

            //리스트에서 상품명 가진 항목 찾기
            FoodItem itemToRemove = foodItems.Find(item => item.ProductName == selectedName);

            //항목이 존재하면 삭제, 없으면 메시지 출력
            if (itemToRemove != null)
            {
                foodItems.Remove(itemToRemove);
                // DB 삭제
                KioskProject.controll.AdminMenuDeletMenu deleter = new KioskProject.controll.AdminMenuDeletMenu();
                bool success = deleter.DeleteMenu(itemToRemove.ProductID);



                //이미지 파일도 함께 삭제
                foreach (DataGridViewRow row in Menu_gridview.Rows)
                {
                    if (row.Cells["ProductID"].Value?.ToString() == itemToRemove.ProductID)
                    {
                        var cellValue = row.Cells["ProductImage"].Value;
                        if (cellValue is Image img)
                        {
                            row.Cells["ProductImage"].Value = null;
                            img.Dispose();
                        }
                        break;
                    }
                }
                //이미지 파일 삭제
                string imagePath = Path.Combine(Application.StartupPath, "MenuImages", itemToRemove.ProductID + ".jpg");
                if (File.Exists(imagePath))
                {
                    try
                    {
                        File.Delete(imagePath);
                    }
                    catch (Exception ex)
                    {
                        ShowMessage("이미지 삭제 중 오류 발생: " + ex.Message);
                    }
                }

                ShowMessage("메뉴가 삭제되었습니다.");


                Menu_gridview.DataSource = null;
                Menu_gridview.ClearSelection();
                Menu_gridview.CurrentCell = null;
                DisplayMenuList();
            }
            else
            {
                ShowMessage("선택한 항목을 찾을 수 없습니다.");
            }
        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = Menu_gridview.CurrentRow;

            if (selectedRow == null)
            {
                ShowMessage("수정할 항목을 선택해주세요.");
                return;
            }

            //상품번호 불러오기
            string originalId = selectedRow.Cells["ProductID"].Value.ToString();

            //입력칸 불러오기
            string id = Num_txt.Text.Trim();
            string name = Name_txt.Text.Trim();
            string price = Price_txt.Text.Trim();
            string category = Category_txt.Text.Trim();
            bool isSpicy = Spicy_checkbox.Checked;
            bool isSize = Size_checkbox.Checked;

            if (id != originalId)
            {
                ShowMessage("상품번호는 수정할 수 없습니다.");
                return;
            }

            // 유효성 검사
            if (!ValidateInput(id, name, price, category, isModify: true))
                return;

            FoodItem itemToUpdate = foodItems.Find(item => item.ProductID == originalId);
            if (itemToUpdate != null)
            {
                itemToUpdate.ProductName = name;
                itemToUpdate.ProductPrice = price;
                itemToUpdate.ProductCategory = category;
                itemToUpdate.IsSpicyOptionEnabled = isSpicy ? 1 : 0;
                itemToUpdate.IsSizeOptionEnabled = isSize ? 1 : 0;

                //DB 수정
                var updater = new KioskProject.controll.AdminMenuUpdate();
                if (updater.UpdateMenu(itemToUpdate))
                {
                    ShowMessage("메뉴가 수정되었습니다.");
                    DisplayMenuList();
                }
            }
            else
            {
                ShowMessage("수정할 항목을 찾을 수 없습니다.");
            }
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
            string productId = Num_txt.Text.Trim();

            // 상품번호가 비어있으면 경고
            if (string.IsNullOrWhiteSpace(productId))
            {
                ShowMessage("상품번호를 먼저 입력해주세요.");
                return;
            }

            // 이미지 업로드 함수 호출
            SaveMenuImage(productId);
        }

        private void totalprice_btn_Click(object sender, EventArgs e)
        {
            TotalSalesReport totalSalesReport = new TotalSalesReport();
            totalSalesReport.Show();
        }
    }
}
