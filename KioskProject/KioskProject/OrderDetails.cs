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
    public partial class OrderDetails : MetroFramework.Forms.MetroForm
    {
        private List<string> orderItems;
        private int totalAmount;
        public OrderDetails(List<string> items, int total)
        {
            InitializeComponent();
            this.orderItems = items;
            this.totalAmount = total;
            this.Load += OrderDetails_Load;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // 🔥 초기화

            foreach (var item in orderItems.Distinct()) // 🔥 혹시 또 중복될까봐
            {
                listBox1.Items.Add(item);
            }

            price_lbl.Text = $"총 결제한 금액: {totalAmount:N0}원";
        }
    }
}
