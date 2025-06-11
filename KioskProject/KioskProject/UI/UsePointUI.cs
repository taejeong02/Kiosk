using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KioskProject
{
    public partial class UsePointUI : Form
    {
        private int _paymentAmount;
        private int _Point;
        private static int _savePoint;
        private static int _UsePoint;
        private static string phonenumber;

        public static UsePointUI Instance;
        public UsePointUI(int Point, int paymentAmount, string number)
        {
            InitializeComponent();
            Instance = this;

            _paymentAmount = paymentAmount;
            _savePoint = (int)(paymentAmount * 0.05);
            UsingPoint.SetSavePoint(_savePoint);
            _Point = Point;
            phonenumber = number;

            label3.Text = $"{_paymentAmount:N0}원";
            label5.Text = $"{_Point:N0}P";
        }

        private void AddDigit(string digit)
        {
            // 현재 textBox1 숫자만 추출
            string digits = new string(textBox1.Text.Where(char.IsDigit).ToArray()) + digit;

            // label3 = 결제금액, label5 = 잔여포인트
            string label3Text = new string(label3.Text.Where(char.IsDigit).ToArray());
            string label5Text = new string(label5.Text.Where(char.IsDigit).ToArray());

            // 숫자로 변환
            if (int.TryParse(digits, out int inputValue) &&
                int.TryParse(label3Text, out int paymentValue) &&
                int.TryParse(label5Text, out int pointValue))
            {
                // 결제금액과 잔여포인트 중 더 작은 값이 최대 허용값
                int maxValue = Math.Min(paymentValue, pointValue);

                if (inputValue <= maxValue)
                {
                    textBox1.Text = inputValue.ToString();
                }
                else
                {
                    textBox1.Text = maxValue.ToString(); // 자동 조정
                }
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void RemoveLastText()
        {
            string digits = new string(textBox1.Text.Where(char.IsDigit).ToArray());
            if (digits.Length > 0)
            {
                digits = digits.Substring(0, digits.Length - 1);
                textBox1.Text = digits;
            }
        }
        private void button1_Click(object sender, EventArgs e) { AddDigit("1"); }
        private void button2_Click(object sender, EventArgs e) { AddDigit("2"); }
        private void button3_Click(object sender, EventArgs e) { AddDigit("3"); }
        private void button4_Click(object sender, EventArgs e) { AddDigit("4"); }
        private void button5_Click(object sender, EventArgs e) { AddDigit("5"); }
        private void button6_Click(object sender, EventArgs e) { AddDigit("6"); }
        private void button7_Click(object sender, EventArgs e) { AddDigit("7"); }
        private void button8_Click(object sender, EventArgs e) { AddDigit("8"); }
        private void button9_Click(object sender, EventArgs e) { AddDigit("9"); }
        private void button0_Click(object sender, EventArgs e) { AddDigit("0"); }
        private void Clearbutton_Click(object sender, EventArgs e) { textBox1.Text = ""; }
        private void Erasebutton_Click(object sender, EventArgs e) { RemoveLastText(); }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            _UsePoint = 0;
            PaymentcompletedUI form3 = new PaymentcompletedUI(_savePoint, _paymentAmount, _UsePoint);
            var result = form3.ShowDialog();
            form3.FormClosed += (s, args) => Application.Exit();
            this.DialogResult = DialogResult.OK; // PaymentUI로 OK 반환
            this.Close();
        }
        private void usePointbutton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text.Replace(",", "").Trim(), out int used))
            {
                int remainingPayment = _paymentAmount - used;
                MessageBox.Show(
                    $"포인트 {used:N0}P를 사용하였습니다.\n" +
                    $"남은 결제 금액: {remainingPayment:N0}원",
                    "포인트 사용 완료",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                _UsePoint = used;
                UsingPoint.SetUsePoint(used);
                PaymentcompletedUI form3 = new PaymentcompletedUI(_savePoint, _paymentAmount, _UsePoint);
                var result = form3.ShowDialog();
                form3.FormClosed += (s, args) => Application.Exit();
                this.DialogResult = DialogResult.OK; // PaymentUI로 OK 반환
                this.Close();
            }
            else
            {
                MessageBox.Show("사용할 포인트를 숫자로 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                label7.Text = (_paymentAmount - int.Parse(textBox1.Text)).ToString("N0") + "원";
            }
            else label7.Text = _paymentAmount.ToString("N0") + "원";
        }

        private void UsePointUI_Load(object sender, EventArgs e)
        {

        }
    }
}
