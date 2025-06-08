using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject
{
    public partial class MenuOption : Form
    {
        private MenuItem selectedItem;
        public MenuOptionData SelectedOption => controller.OptionData;

        private MenuOptionController controller;
        public MenuOption(MenuItem item)
        {
            InitializeComponent();
            selectedItem = item;
            controller = new MenuOptionController(item.Price);

            // 초기화 UI
            lblMenuName.Text = item.Name;
            UpdateQuantity();
            UpdatePrice();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void UpdatePrice()
        {
            int total = controller.GetTotalPrice();
            lblPrice.Text = $"{total}원";
        }
        private void UpdateQuantity()
        {
            lblQuantity.Text = controller.GetQuantity().ToString();
        }
        private void btnMiddle_Click(object sender, EventArgs e)
        {
            controller.SetUpsize(false); // ✅
            btnMiddle.BackColor = Color.LightBlue;
            btnLaze.BackColor = SystemColors.Control;
            UpdatePrice();
        }
        private void btnLaze_Click(object sender, EventArgs e)
        {
            controller.SetUpsize(true);
            btnLaze.BackColor = Color.LightBlue;
            btnMiddle.BackColor = SystemColors.Control;
            UpdatePrice();
        }
       

        private void btnone_Click(object sender, EventArgs e)
        {
            controller.SetSpiciness("순한맛");
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            controller.SetSpiciness("보통맛");
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            controller.SetSpiciness("매운맛");
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            controller.SetSpiciness("엄청매운맛");
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            controller.IncreaseQty();
            UpdateQuantity();
            UpdatePrice();
        }

        private void btnmius_Click(object sender, EventArgs e)
        {
            controller.DecreaseQty();
            UpdateQuantity();
            UpdatePrice();
        }

        private void MenuOption_Load(object sender, EventArgs e)
        {
            lblMenuName.Text = selectedItem.Name;
            UpdatePrice();
            UpdateQuantity();

            // 옵션 UI 보이기 여부
            pnlSizeOption.Visible = selectedItem.IsSizeOptionEnabled;
            pnlSpicyOption.Visible = selectedItem.IsSpicyOptionEnabled;

            int y = lblMenuName.Bottom + 10;

            if (pnlSizeOption.Visible)
            {
                pnlSizeOption.Location = new Point(pnlSizeOption.Location.X, y);
                y = pnlSizeOption.Bottom + 10;
            }

            if (pnlSpicyOption.Visible)
            {
                pnlSpicyOption.Location = new Point(pnlSpicyOption.Location.X, y);
                y = pnlSpicyOption.Bottom + 10;
            }

            pnlBottomArea.Location = new Point(pnlBottomArea.Location.X, y);
        }

        private void btnLaze_Click_1(object sender, EventArgs e)
        {
            controller.SetUpsize(true);
            btnLaze.BackColor = Color.LightBlue;
            btnMiddle.BackColor = SystemColors.Control;
            UpdatePrice();
        }

        private void btnMiddle_Click_1(object sender, EventArgs e)
        {
            controller.SetUpsize(false);
            btnMiddle.BackColor = Color.LightBlue;
            btnLaze.BackColor = SystemColors.Control;
            UpdatePrice();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSpicyOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
