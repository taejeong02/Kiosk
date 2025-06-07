using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject.UI
{
    public partial class CartUI : MetroFramework.Forms.MetroForm
    {
        private OrderUI previousForm;
        public CartUI(OrderUI prevForm, List<CartItem> items)
        {
            InitializeComponent();
            this.previousForm = prevForm;

            SetupCartGrid();
            LoadCartItems(items);
        }
        private void SetupCartGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ItemNo", "상품 번호");
            dataGridView1.Columns.Add("ItemName", "상품명");
            dataGridView1.Columns.Add("Qty", "상품 수량");
            dataGridView1.Columns.Add("Price", "상품 가격");

            dataGridView1.AllowUserToAddRows = false;
        }
        private void LoadCartItems(List<CartItem> items)
        {
            dataGridView1.Rows.Clear();
            int itemNo = 1;

            foreach (var item in items)
            {
                int totalPrice = item.TotalPrice;
                int qty = item.Quantity;

                // 메뉴명 가공: 곱빼기 + 맵기
                string nameWithOption = item.Name;

                if (item.IsUpsize)
                    nameWithOption += "-곱빼기";

                if (!string.IsNullOrEmpty(item.Spiciness))
                    nameWithOption += $"-{item.Spiciness}";

                // DataGridView에 행 추가
                dataGridView1.Rows.Add(
                    itemNo++,
                    nameWithOption,
                    qty,
                    totalPrice
                );
            }

            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["Price"].Value);
                }
            }
            lbltotal.Text = $"총 결제 금액 : {total:N0}원";
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
    }

}
