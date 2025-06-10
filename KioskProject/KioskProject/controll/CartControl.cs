using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KioskProject
{
    public class CartControl
    {
        // DataGridView 컬럼 세팅
        public void SetupCartGrid(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("ItemNo", "상품 번호");
            dataGridView.Columns.Add("ItemName", "상품명");
            dataGridView.Columns.Add("Qty", "상품 수량");
            dataGridView.Columns.Add("Price", "상품 가격");

            dataGridView.AllowUserToAddRows = false;
        }

        // 장바구니 아이템 로딩
        public void LoadCartItems(DataGridView dataGridView, List<string> items)
        {
            dataGridView.Rows.Clear();
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

                dataGridView.Rows.Add(
                    itemNo++,
                    itemName,
                    qty,
                    price
                );
            }
        }

        // 총 금액 계산
        public int UpdateTotalPrice(DataGridView dataGridView, Label lblTotal)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["Price"].Value);
                }
            }
            if (lblTotal != null)
                lblTotal.Text = $"총 결제 금액 : {total:N0}원";
            return total;
        }

        // 장바구니 아이템 반환
        public List<string> GetCartItems(DataGridView dataGridView)
        {
            List<string> items = new List<string>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string menu = row.Cells["ItemName"].Value.ToString();
                    string qty = row.Cells["Qty"].Value.ToString();
                    string price = row.Cells["Price"].Value.ToString();

                    items.Add($"{menu} - {qty}개 : {price}원");
                }
            }
            return items.Distinct().ToList();
        }
    }
}
