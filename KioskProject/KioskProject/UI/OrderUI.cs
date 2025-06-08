using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;

namespace KioskProject
{
    public partial class OrderUI : Form
    {
        Form previousForm; // 이전 폼을 저장할 변수 => Select_LanguageUI에서 매장을 선택하면 해당 폼이 출력되며
                           // Select_LanguageUI가 종료되는 것이 아니라 Hide 숨겨짐. 이후 OrderUI의 뒤로가기 버튼을 누르면
                           // Select_LanguageUI를 다시 표시하기 위한 작업
        private Dictionary<string, int> orderList = new Dictionary<string, int>();
        public OrderUI(Form prevForm) // Select_LanguageUI의 정보를 넘겨받기 위해 인자를 설정해야함 => 이전 폼을 저장할 변수    
        {
            InitializeComponent();
            this.previousForm = prevForm; // Select_LanguageUI의 정보를 previousForm에 저장
        }


        //DB에서 카테고리 목록 불러오기
        private List<string> LoadCategoriesFromDB()
        {
            return Category.GetAllCategoryNames();
        }

        private List<string> allCategories = new List<string>();
        private int currentPage = 0;
        private const int itemsPerPage = 7;
        //폼 첫 로드 시 호출, 카운트 초기화, 카테고리 버튼 생성
        private void OrderUI_Load(object sender, EventArgs e)
        {
            count.Text = "0";
            GenerateCategoryButtons();
        }


        //자동 증가 카테고리 버튼
        private void GenerateCategoryButtons()
        {
            allCategories = LoadCategoriesFromDB();  // 전체 카테고리 저장
            currentPage = 0;                         // 첫 페이지로 초기화
            ShowCategoryPage();                      // 페이지 표시
        }
        //현재 페이지 카테고리 버튼 생성
        private void ShowCategoryPage()
        {
            flowLayoutPanel2.Controls.Clear();

            int start = currentPage * itemsPerPage;
            int end = Math.Min(start + itemsPerPage, allCategories.Count);

            for (int i = start; i < end; i++)
            {
                string category = allCategories[i];

                Button btn = new Button();
                btn.Text = category;
                btn.Width = 100;
                btn.Height = 50;
                btn.Margin = new Padding(5);
                btn.Tag = category;

                btn.Click += (s, e) =>
                {
                    string selectedCategory = (string)((Button)s).Tag;
                    LoadMenuByCategory(selectedCategory);
                };

                flowLayoutPanel2.Controls.Add(btn);
            }

            // 다음/이전 버튼 붙이기
            if (currentPage > 0)
            {
                Button prevBtn = new Button();
                prevBtn.Text = "이전";
                prevBtn.Width = 100;
                prevBtn.Height = 50;
                prevBtn.Margin = new Padding(5);
                prevBtn.Click += (s, e) =>
                {
                    currentPage--;
                    ShowCategoryPage();
                };
                flowLayoutPanel2.Controls.Add(prevBtn);
            }

            if (end < allCategories.Count)
            {
                Button nextBtn = new Button();
                nextBtn.Text = "다음";
                nextBtn.Width = 100;
                nextBtn.Height = 50;
                nextBtn.Margin = new Padding(5);
                nextBtn.Click += (s, e) =>
                {
                    currentPage++;
                    ShowCategoryPage();
                };
                flowLayoutPanel2.Controls.Add(nextBtn);
            }
        }

        //특정 카테고리에 해당하는 메뉴 db에 불러오기
        private void LoadMenuByCategory(string category)
        {
            flowLayoutPanel1.Controls.Clear();

            var cat = new Category { CategoryName = category };
            List<MenuItem> items = cat.GetItems();

            foreach (var item in items)
            {
                var myItem = new MyMenuItem(item.Name, item.Price, item.Category, item.IsSpicyOptionEnabled, item.IsSizeOptionEnabled);
                string imagePath = Path.Combine(Application.StartupPath, "MenuImages", item.Name + ".jpg");

                Panel panel = new Panel
                {
                    Width = 120,
                    Height = 150,
                    Margin = new Padding(5),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox picture = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                if (File.Exists(imagePath))
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        picture.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    picture.BackColor = Color.LightGray;
                }

                Label nameLabel = new Label
                {
                    Text = item.Name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("맑은 고딕", 10, FontStyle.Bold),
                    Height = 40
                };

                Label priceLabel = new Label
                {
                    Text = item.Price.ToString("N0") + "원",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("맑은 고딕", 9),
                    Height = 30
                };

                EventHandler clickHandler = (s, e) =>
                {
                    MenuOption optionForm = new MenuOption(myItem);
                    if (optionForm.ShowDialog() == DialogResult.OK)
                    {
                        AddToOrder(myItem, optionForm.SelectedOption);
                    }
                };

                panel.Click += clickHandler;
                picture.Click += clickHandler;
                nameLabel.Click += clickHandler;
                priceLabel.Click += clickHandler;

                panel.Controls.Add(picture);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(nameLabel);
                flowLayoutPanel1.Controls.Add(panel);
            }
        
   
                }
            
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddToOrder(MyMenuItem item, MenuOptionData option)
        {
            string upsizeText = option.IsUpsize ? "곱빼기-" : "";
            string key = $"{item.Name}-{upsizeText}{option.Spiciness}-{option.Quantity}개";
            int totalPrice = option.CalculateTotalPrice(item.Price);

            listBox1.Items.Add($"{key} : {totalPrice}원");

            if (int.TryParse(count.Text, out int countValue))
            {
                countValue += option.Quantity;
                count.Text = countValue.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show(); // 숨겨둔 이전 폼 Select_LanguageUI 다시 보여줌
            this.Close(); // 현재 폼 종료
        }
        private void flowLayoutPanelCategory(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void RestoreCartFromData()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cartLines = new List<string>();
            foreach (var obj in listBox1.Items)
            {
                cartLines.Add(obj.ToString());
            }

            CartUI cartForm = new CartUI(this, cartLines);
            cartForm.FormClosed += (s, args) => Application.Exit();
            cartForm.Show();           // ← 이거 추가해야 폼 뜸
            this.Hide();               // ← 숨기고 싶으면 이 줄도 추가
        }
    }

    //사용자 정의 메뉴 항목 클래스 메뉴,이름, 가격, 카테고리 포함
    public class MyMenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public bool IsSpicyOptionEnabled { get; set; }
        public bool IsSizeOptionEnabled { get; set; }

        public MyMenuItem(string name, int price, string category, bool isSpicy, bool isSize)
        {
            Name = name;
            Price = price;
            Category = category;
            IsSpicyOptionEnabled = isSpicy;
            IsSizeOptionEnabled = isSize;
        }
    }
}