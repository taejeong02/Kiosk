using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskProject;
using KioskProject.controll;

namespace KioskProject
{
    public partial class PaymentcompletedUI : Form
    {
        private int _savePoint;
        private int _updatedPoint;
        private int _paymentAmount;
        private int _usePoint;

        private System.Windows.Forms.Timer inactivityTimer;
        private int remainingTime = 10;
        private PaymentUI previousCartForm;

        public PaymentcompletedUI(int savePoint, int paymentAmount, int usePoint, PaymentUI payform)
        {
            InitializeComponent();
            _savePoint = savePoint;
            _paymentAmount = paymentAmount - usePoint;
            _usePoint = usePoint;
            this.previousCartForm = payform;
            StartInactivityTimer();
        }
        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (_savePoint != 0)
            {
                _updatedPoint = UsingPoint.UsePoint();
                _updatedPoint = UsingPoint.AddPoint();
                MessageBox.Show(
                    $"결제금액 {_paymentAmount:N0}원이 결제 되었습니다.\n" +
                    $"사용한 포인트 {_usePoint:N0}P\n" +
                    $"포인트 {_savePoint:N0}P가 적립되었습니다.\n" +
                    $"현재 잔여 포인트: {_updatedPoint:N0}P",
                    "결제 및 포인트 적립 완료",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"결제금액 {_paymentAmount:N0}원이 결제 되었습니다.\n",
                    "결제 완료",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PaymentcompletedUI_Load(object sender, EventArgs e)
        {

        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            // 타이머 남은 시간 라벨이 있다면 업데이트
            Count.Text = $"남은 시간: {remainingTime}초";

            if (remainingTime <= 0)
            {
                inactivityTimer.Stop();
                previousCartForm.remainingTime = 0;
                TimerControl.CloseAllFormsExceptShopPacking();
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
            Count.Text = $"남은 시간: {remainingTime}초";
        }
    }
}
