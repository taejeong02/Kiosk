using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskProject.controll;

namespace KioskProject
{
    public partial class CartUI : MetroFramework.Forms.MetroForm
    {
        public static int _total;
        private OrderUI previousForm;
        private ShopPacking previousForm2;
        private CartControl cartControl;
        private List<string> cartLines;
        private PaymentUI paymentForm;

        private System.Windows.Forms.Timer inactivityTimer;
        private int remainingTime = 10;

        public CartUI(OrderUI prevForm, List<string> items, ShopPacking shopPackingForm)
        {
            InitializeComponent();
            this.previousForm = prevForm;
            this.previousForm2 = shopPackingForm;
            this.cartLines = new List<string>(items);
            cartControl = new CartControl();

            cartControl.SetupCartGrid(dataGridView1);
            cartControl.LoadCartItems(dataGridView1, items);
            UpdateTotalPrice();
            StartInactivityTimer(); // ← 타이머 시작
        }

        private void UpdateTotalPrice()
        {
            _total = cartControl.UpdateTotalPrice(dataGridView1, lbltotal);
            // 카트의 총 금액이 0이 되면 OrderUI로 돌아감
            if (_total == 0 && this.Visible) // 현재 폼이 화면에 보일 때만 실행 (불필요한 동작 방지)
            {
                MessageBox.Show("장바구니가 비었습니다. 상품 선택 화면으로 돌아갑니다.", "장바구니 비었음", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backbtn_Click(this, EventArgs.Empty); // backbtn_Click 이벤트 핸들러 호출
            }
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
            inactivityTimer.Stop();
            cartLines = cartControl.GetCartItems(dataGridView1); // 최신 내용으로 갱신
            previousForm.RestoreCartFromData(cartLines);         // 복원 전달
            previousForm.Show();
            this.Close();
        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            int totalPrice = _total;
            remainingTime = 0;
            // 폼이 null이거나 이미 dispose된 경우에만 새로 생성
            if (paymentForm == null || paymentForm.IsDisposed)
            {
                paymentForm = new PaymentUI(totalPrice, this, previousForm2);
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
            remainingTime = 10;
            this.Hide();
        }
        public List<string> GetCartItems()
        {
            return cartControl.GetCartItems(dataGridView1);
        }

        private void cashbtn_Click(object sender, EventArgs e)
        {
            inactivityTimer.Stop();

            // 관리자 폼에서 승인 여부를 확인
            var adminForm = Application.OpenForms.OfType<KioskAdminMenu>().FirstOrDefault();
            if (adminForm != null && adminForm.IsCashPaymentApproved())
            {
                // 결제 승인 처리
                MessageBox.Show("결제가완료되었습니다.", "결제 승인", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 총 결제 금액 계산
                int totalPrice = _total;

                // OrderDetails 폼을 열고, 결제 금액을 넘겨줌
                OrderDetails orderDetails = new OrderDetails(cartLines, totalPrice);
                orderDetails.Show(); // 결제 내역을 표시할 폼 실행

                // 결제 완료 후 카트 데이터를 비우고, ShopPacking으로 돌아가도록 처리
                StaticCartData.Clear();
            }
            else
            {
                // 관리자 승인 안된 경우, 승인 요청 메시지 표시
                MessageBox.Show("카운터에서 결제를 완료해주세요.", "결제 승인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CartUI_Load(object sender, EventArgs e)
        {

        }

        public static class StaticCartData
        {
            public static List<string> CartItems = new List<string>();
            public static void Clear()
            {
                CartItems.Clear();
                // 필요하면 여기에 다른 전역 데이터도 같이 초기화
            }
        }
        public void InactivityTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            // 타이머 남은 시간 라벨이 있다면 업데이트
            Timer.Text = $"남은 시간: {remainingTime}초";

            if (remainingTime <= 0)
            {
                inactivityTimer.Stop();
                StaticCartData.Clear(); // 저장된 카트 정보 초기화

                // 이전 OrderUI 폼 닫기
                if (previousForm != null && !previousForm.IsDisposed)
                {
                    previousForm.Close();
                }

                // 초기화면 ShopPacking 다시 보여주기
                if (previousForm2 != null)
                {
                    previousForm2.Show(); // ShopPacking 폼을 직접 표시
                }

                this.Close(); // CartUI 닫기
            }
        }
        private void StartInactivityTimer()
        {
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = 1000; // 1초마다
            inactivityTimer.Tick += InactivityTimer_Tick;
            inactivityTimer.Start();

            this.MouseMove += ResetInactivityTimer;
            this.MouseClick += ResetInactivityTimer;
        }
        public void CartUI_Activated(object sender, EventArgs e)
        {
            StartInactivityTimer(); // 타이머 다시 시작
        }
        private void ResetInactivityTimer(object sender, EventArgs e)
        {
            remainingTime = 10;
            Timer.Text = $"남은 시간: {remainingTime}초";
        }
    }
}