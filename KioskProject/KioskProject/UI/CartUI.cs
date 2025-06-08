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
        public CartUI(OrderUI prevForm, List<string> items)
        {
            InitializeComponent();
            this.previousForm = prevForm;

            SetupCartGrid();
            LoadCartItems(items);  // items는 List<string>
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
        private void LoadCartItems(List<string> items)
        {
            dataGridView1.Rows.Clear();
            int itemNo = 1;

            foreach (string line in items)
            {
                string[] parts = line.Split(':');
                string namePart = parts[0].Trim();
                string pricePart = parts[1].Replace("원", "").Trim();
                int price = int.Parse(pricePart);

                string[] nameParts = namePart.Split('-');
                string itemName = string.Join("-", nameParts.Take(nameParts.Length - 1));
                string qtyStr = nameParts.Last().Replace("개", "");
                int qty = int.Parse(qtyStr);

                dataGridView1.Rows.Add(
                    itemNo++,
                    itemName,
                    qty,
                    price
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
            _total = total;
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
        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    totalPrice += Convert.ToInt32(row.Cells["Price"].Value);
                }
            }

            PaymentUI paymentForm = new PaymentUI(totalPrice, this);
            paymentForm.FormClosed += (s, args) => Application.Exit();
            paymentForm.Show();
            this.Hide(); // CartUI는 숨기기만
        }
        public List<string> GetCartItems()
        {
            List<string> items = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string menu = row.Cells["ItemName"].Value.ToString();
                    string qty = row.Cells["Qty"].Value.ToString();
                    string price = row.Cells["Price"].Value.ToString();

                    items.Add($"{menu} - {qty}개 : {price}원");
                }
            }
            return items.Distinct().ToList(); // 중복제거
        }
    }

}
