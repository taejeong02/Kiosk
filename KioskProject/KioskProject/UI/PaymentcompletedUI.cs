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
    public partial class PaymentcompletedUI : MetroFramework.Forms.MetroForm
    {
        private int _savePoint;
        private int _updatedPoint;
        private int _paymentAmount;
        private int _usePoint;

        public PaymentcompletedUI(int savePoint, int paymentAmount, int usePoint)
        {
            InitializeComponent();
            _savePoint = savePoint;
            _paymentAmount = paymentAmount - usePoint;
            _usePoint = usePoint;
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
    }
}
