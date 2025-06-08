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
        private Timer autoTimer;
        private int orderId;

        public OrderDetails(List<string> items, int total)
        {
            InitializeComponent();
            this.orderItems = items;
            this.totalAmount = total;
            this.Load += OrderDetails_Load;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in orderItems.Distinct())
                listBox1.Items.Add(item);

            price_lbl.Text = $"총 결제한 금액: {totalAmount:N0}원";

            // 주문을 먼저 저장하고 orderId 확보
            OrderInfo order = new OrderInfo
            {
                OrderDate = DateTime.Now,
                TotalAmount = totalAmount,
                OrderData = string.Join("\n", orderItems)
            };
            this.orderId = order.SaveToDatabase();
            if (this.orderId <= 0)
            {
                MessageBox.Show("주문 저장에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 타이머를 반드시 한 번만 생성 & 등록
            if (autoTimer == null)
            {
                autoTimer = new Timer();
                autoTimer.Interval = 3000; // 3초(3000ms)
                autoTimer.Tick += AutoTimer_Tick;
                autoTimer.Start();
            }
        }
        private void AutoTimer_Tick(object sender, EventArgs e)
        {
            if (autoTimer != null)
            {
                autoTimer.Stop();
                autoTimer.Tick -= AutoTimer_Tick;
                autoTimer.Dispose();
                autoTimer = null;
            }
            ReceiptControl.ShowReceipt(orderId);
            this.Close();
        }
    }
}
