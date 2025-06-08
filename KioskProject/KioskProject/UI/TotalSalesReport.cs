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
            List<OrderInfo> orders = OrderInfo.GetAllOrders();
            var (total, year, month, day) = SalesInquiry.CalculateSales(orders);

            totalprice_lbl.Text = $"{total}원";
            yearprice_lbl.Text = $"{year}원";
            monthprice_lbl.Text = $"{month}원";
            dayprice_lbl.Text = $"{day}원";
        }
    }
}
