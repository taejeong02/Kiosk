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
    public partial class CartUI : MetroFramework.Forms.MetroForm
    {
        public static int _total;
        private OrderUI previousForm;
        private CartControl cartControl;
        private List<string> cartLines;
        private PaymentUI paymentForm;
        
        public CartUI(OrderUI prevForm, List<string> items)
        {
            InitializeComponent();
            this.previousForm = prevForm;
            this.cartLines = new List<string>(items);
            cartControl = new CartControl();

            cartControl.SetupCartGrid(dataGridView1);
            cartControl.LoadCartItems(dataGridView1, items);
            UpdateTotalPrice();
        }
        
        private void UpdateTotalPrice()
        {
            _total = cartControl.UpdateTotalPrice(dataGridView1, lbltotal);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Plusbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var row = dataGridView1.SelectedRows[0];
            int qty = Convert.ToInt32(row.Cells["Qty"].Value);
            int price = Convert.ToInt32(row.Cells["Price"].Value);

            int unitPrice = qty == 0 ? 0 : price / qty;

            qty++;
            row.Cells["Qty"].Value = qty;
            row.Cells["Price"].Value = unitPrice * qty;

            UpdateTotalPrice();
        }

        private void Miusbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var row = dataGridView1.SelectedRows[0];
            int qty = Convert.ToInt32(row.Cells["Qty"].Value);
            int price = Convert.ToInt32(row.Cells["Price"].Value);

            if (qty <= 1)
            {
                dataGridView1.Rows.Remove(row);
            }
            else
            {
                int unitPrice = price / qty;
                qty--;
                row.Cells["Qty"].Value = qty;
                row.Cells["Price"].Value = unitPrice * qty;
            }
            UpdateTotalPrice();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            cartLines = cartControl.GetCartItems(dataGridView1); // 최신 내용으로 갱신
            previousForm.RestoreCartFromData(cartLines);         // 복원 전달
            previousForm.Show();
            this.Close();
        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            int totalPrice = _total;


            // 폼이 null이거나 이미 dispose된 경우에만 새로 생성
            if (paymentForm == null || paymentForm.IsDisposed)
            {
                paymentForm = new PaymentUI(totalPrice, this);
            }

            // 숨겨져 있으면 다시 보여주기
            if (!paymentForm.Visible)
            {
                paymentForm.Show();
            }
            else
            {
                paymentForm.BringToFront(); // 이미 떠 있으면 앞으로
            }

            this.Hide(); // CartUI는 숨김
        }
        public List<string> GetCartItems()
        {
            return cartControl.GetCartItems(dataGridView1);
        }

        private void cashbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현금 결제는 카운터에서 진행해주세요!","현금 결제",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void CartUI_Load(object sender, EventArgs e)
        {

        }
    }

}
