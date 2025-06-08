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
        public CartUI(OrderUI prevForm, List<string> items)
        {
            InitializeComponent();
            this.previousForm = prevForm;
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
            previousForm.RestoreCartFromData(); // ← 리스트 복원
            previousForm.Show();                // 폼 다시 보여줌
            this.Close();
        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            int totalPrice = _total;
            PaymentUI paymentForm = new PaymentUI(totalPrice, this);
            paymentForm.FormClosed += (s, args) => Application.Exit();
            paymentForm.Show();
            this.Hide();
        }
        public List<string> GetCartItems()
        {
            return cartControl.GetCartItems(dataGridView1);
        }
    }

}
