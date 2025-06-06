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
using MetroFramework.Forms;

namespace KioskProject
{
    public partial class OrderUI : MetroForm
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

        private void OrderUI_Load(object sender, EventArgs e)
        {
            count.Text = "0";
        }

        private void LoadMenuByCategory(string category)
        {
            flowLayoutPanel1.Controls.Clear();

            var items = Category.GetMenuByCategory(category);
            foreach (var item in items)
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 120;
                btn.Text = item.Name;
                btn.TextAlign = ContentAlignment.TopCenter;

                string fullImagePath = item.GetFullImagePath();
                if (File.Exists(fullImagePath))
                {
                    btn.BackgroundImage = Image.FromFile(fullImagePath);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    btn.Text += "\n(이미지 없음)";
                }
                flowLayoutPanel1.Controls.Add(btn);

                // 카테고리체크
                btn.Click += (s, e) =>
                {
                    if (category == "밥류" || category == "면류" || category == "세트메뉴" || category == "추천메뉴")
                    {
                        // 옵션창 띄우고 선택 결과 반영
                        MenuOption optionForm = new MenuOption(item);
                        if (optionForm.ShowDialog() == DialogResult.OK)
                        {
                            var result = optionForm.SelectedOption;
                            AddToOrder(item, result);
                        }
                    }
                    else // 사이드, 주류, 음료류 등 옵션 없이 바로 추가
                    {
                        string searchKey = $"{item.Name}--";
                        int foundIdx = -1;
                        int currentQty = 0;

                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            string str = listBox1.Items[i].ToString();
                            if (str.StartsWith(searchKey))
                            {
                                foundIdx = i;
                                // 수량 추출: "이름--수량개 : "
                                int startIdx = str.IndexOf("--") + 2;
                                int endIdx = str.IndexOf("개");
                                if (startIdx >= 2 && endIdx > startIdx)
                                {
                                    int.TryParse(str.Substring(startIdx, endIdx - startIdx), out currentQty);
                                }
                                break;
                            }
                        }

                        if (foundIdx != -1)
                        {
                            // 기존 항목 업데이트
                            currentQty++;
                            int totalPrice = item.Price * currentQty;
                            listBox1.Items[foundIdx] = $"{item.Name}--{currentQty}개 : {totalPrice}원";
                        }
                        else
                        {
                            // 신규 추가
                            int totalPrice = item.Price;
                            listBox1.Items.Add($"{item.Name}--1개 : {totalPrice}원");
                        }

                        // count 갱신
                        if (int.TryParse(count.Text, out int countValue))
                        {
                            countValue++;
                            count.Text = countValue.ToString();
                        }
                    }
                };
            }
        }
        private void btnNoodles_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("면류");
        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("밥류");
        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("사이드");
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("주류");
        }

        private void btnAlcohol_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("음료류");
        }

        private void btnsuggestion_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("추천메뉴");
        }

        private void btnSetmenu_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory("세트메뉴");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddToOrder(MenuItem item, MenuOptionData option)
        {
            string upsizeText = option.IsUpsize ? "곱빼기-" : "";
            string key = $"{item.Name}-{upsizeText}{option.Spiciness}-{option.Quantity}개";
            int totalPrice = option.CalculateTotalPrice(item.Price);

            listBox1.Items.Add($"{key} : {totalPrice}원");

            // CartData에도 추가
            CartData.Items.Add(new CartItem
            {
                Name = item.Name,
                IsUpsize = option.IsUpsize,
                Spiciness = option.Spiciness,
                Quantity = option.Quantity,
                TotalPrice = totalPrice
            });

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static class CartData
        {
            public static List<CartItem> Items = new List<CartItem>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CartUI cartForm = new CartUI();
            cartForm.Show();

        }
    }
}