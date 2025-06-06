using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject
{
    public partial class KioskAdminMenu : Form
    {
        public class FoodItem
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public string ProductPrice { get; set; }
            public string ProductCategory { get; set; }
        }

        private List<FoodItem> foodItems = new List<FoodItem>();

        private string connectionString = "server=localhost;database=MenuDB;uid=appuser;pwd=KioskProjectghguddeumk2";


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
                        ProductCategory = reader["ProductCategory"].ToString()
                    });
                }
            }

            Menu_gridview.DataSource = null;
            Menu_gridview.DataSource = foodItems;
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
            if (!IsInputEmpty())
            {
                ShowMessage("메뉴 추가를 완료하고 종료해주세요");
                return;
            }
            //초기화면 로딩
            Select_Language main = new Select_Language();
            main.Show();

            //현재 폼 숨기기
            this.Hide();
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
        }

        private void Addmenu_btn_Click(object sender, EventArgs e)
        {
            //ID수정 방지 위한 읽기 모드
            Num_txt.ReadOnly = false;

            //입력값 가져오기
            string id = Num_txt.Text.Trim();
            string name = Name_txt.Text.Trim();
            string price = Price_txt.Text.Trim();
            string category = Category_txt.Text.Trim();

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
                ProductCategory = category
            };
            foodItems.Add(newItem);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO menu (ProductID, ProductName, ProductPrice, ProductCategory)" +
                               "VALUES (@id, @name, @price, @category)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.ExecuteNonQuery();
            }

            //메뉴 추가 성공 메시지 출력
            ShowMessage("메뉴가 등록되었습니다.");

            //입력 필드 초기화
            Num_txt.Text = "";
            Name_txt.Text = "";
            Price_txt.Text = "";
            Category_txt.Text = "";
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

            //리스트에서 상품명 가진 항목 찾기
            FoodItem itemToRemove = foodItems.Find(item => item.ProductName == selectedName);

            //항목이 존재하면 삭제, 없으면 메시지 출력
            if (itemToRemove != null)
            {
                foodItems.Remove(itemToRemove);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM menu WHERE ProductID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", itemToRemove.ProductID);
                    cmd.ExecuteNonQuery();
                }
                ShowMessage("메뉴가 삭제되었습니다.");
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

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE menu SET ProductName = @name, ProductPrice = @price, ProductCategory = @category WHERE ProductID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.ExecuteNonQuery();
                }

                ShowMessage("메뉴가 수정되었습니다.");
                DisplayMenuList();
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
    }
}
