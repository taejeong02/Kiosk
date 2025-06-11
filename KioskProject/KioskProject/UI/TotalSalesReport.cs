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
    public partial class TotalSalesReport : MetroFramework.Forms.MetroForm
    {
        public TotalSalesReport()
        {
            InitializeComponent();
        }

        private void TotalSalesReport_Load(object sender, EventArgs e)
        {
            if (SalesInquiry.TryCalculateSales(out var result))
            {
                var (total, year, month, day) = result;

                totalprice_lbl.Text = $"{total}원";
                yearprice_lbl.Text = $"{year}원";
                monthprice_lbl.Text = $"{month}원";
                dayprice_lbl.Text = $"{day}원";
            }
            else
            {
                MessageBox.Show("매출 정보를 불러오는 데 실패했습니다.\n잠시 후 다시 시도해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // 폼 종료
            }
            /*List<OrderInfo> orders = OrderInfo.GetAllOrders();
            var (total, year, month, day) = SalesInquiry.CalculateSales(orders);

            totalprice_lbl.Text = $"{total}원";
            yearprice_lbl.Text = $"{year}원";
            monthprice_lbl.Text = $"{month}원";
            dayprice_lbl.Text = $"{day}원";*/
        }
    }
}
