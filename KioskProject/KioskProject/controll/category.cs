using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity = KioskProject.entity;


namespace KioskProject
{
    public class Category
    {
        public string CategoryName { get; set; }

        public static List<string> GetAllCategoryNames()
        {
            return Entity.MenuDataItem.GetAllCategories();
        }

        public List<Entity.MenuDataItem> GetItems()
        {
            return Entity.MenuDataItem.GetMenuItemsFromDB(this.CategoryName);
        }

        // 해당 카테고리 메뉴를 패널에 뿌려주기
        public static void LoadMenuByCategory(string categoryName, FlowLayoutPanel panel, Action<Entity.MenuDataItem, MenuOptionData> onAddToOrder)
        {
            panel.Controls.Clear();

            var cat = new Category { CategoryName = categoryName };
            List<Entity.MenuDataItem> items = cat.GetItems();

            foreach (var item in items)
            {
                string imagePath = Path.Combine(Application.StartupPath, "MenuImages", item.Name + ".jpg");

                Panel panelItem = new Panel
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
                        Image tempImage = Image.FromStream(fs);
                        picture.Image = new Bitmap(tempImage);
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
                    MenuOption optionForm = new MenuOption(item); // MenuItem 객체 그대로 넘김
                    if (optionForm.ShowDialog() == DialogResult.OK)
                    {
                        onAddToOrder(item, optionForm.SelectedOption);
                    }
                };

                panelItem.Click += clickHandler;
                picture.Click += clickHandler;
                nameLabel.Click += clickHandler;
                priceLabel.Click += clickHandler;

                panelItem.Controls.Add(picture);
                panelItem.Controls.Add(priceLabel);
                panelItem.Controls.Add(nameLabel);
                panel.Controls.Add(panelItem);
            }
        }

        // 카테고리 버튼들을 패널에 페이징 방식으로 출력
        public static void ShowCategoryPage(
            FlowLayoutPanel categoryPanel, 
            List<string> categories,
            int currentPage,
            int itemsPerPage,
            Action<string> onCategoryClick,
            Action onPrevClick,
            Action onNextClick)
        {
            categoryPanel.Controls.Clear();
            int start = currentPage * itemsPerPage;
            int end = Math.Min(start + itemsPerPage, categories.Count);

            for (int i = start; i < end; i++)
            {
                string category = categories[i];

                Button btn = new Button
                {
                    Text = category,
                    Width = 100,
                    Height = 50,
                    Margin = new Padding(5),
                    Tag = category
                };

                btn.Click += (s, e) =>
                {
                    string selectedCategory = (string)((Button)s).Tag;
                    onCategoryClick(selectedCategory);
                };

                categoryPanel.Controls.Add(btn);
            }

            if (currentPage > 0)
            {
                Button prevBtn = new Button { Text = "이전", Width = 100, Height = 50 };
                prevBtn.Click += (s, e) => onPrevClick();
                categoryPanel.Controls.Add(prevBtn);
            }

            if (end < categories.Count)
            {
                Button nextBtn = new Button { Text = "다음", Width = 100, Height = 50 };
                nextBtn.Click += (s, e) => onNextClick();
                categoryPanel.Controls.Add(nextBtn);
            }
        }

        // 주문리스트에 항목 추가
        public static void AddToOrder(Entity.MenuDataItem item, MenuOptionData option, ListBox listBox, Label countLabel)
        {
            string upsizeText = option.IsUpsize ? "곱빼기-" : "";
            string key = $"{item.Name}-{upsizeText}{option.Spiciness}-{option.Quantity}개";
            int totalPrice = option.CalculateTotalPrice(item.Price);

            listBox.Items.Add($"{key} : {totalPrice}원");

            if (int.TryParse(countLabel.Text, out int countValue))
            {
                countValue += option.Quantity;
                countLabel.Text = countValue.ToString();
            }
        }
    }
}
