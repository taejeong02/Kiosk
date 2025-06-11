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
using KioskProject;

namespace KioskProject
{
    public partial class SavePointUI : Form
    {
        public static int PaymentAmount;
        public int point;
        public string phone;

        private System.Windows.Forms.Timer inactivityTimer;
        private int remainingTime = 10;
        private PaymentUI previousCartForm;

        public SavePointUI(int payment, PaymentUI payform)
        {
            InitializeComponent();
            this.previousCartForm = payform;
            PaymentAmount = payment;
            textBox1.Text = "010 - ";
            label3.Text = ((int)(PaymentAmount * 0.05)).ToString("N0") + "P";
            StartInactivityTimer();
        }

        public int FindPoint(string phone)
        {
            if (!UsingPoint.IsExistingUser(phone))
            {
                UsingPoint.InsertUser(phone);
                MessageBox.Show($"[신규등록] {phone} 사용자 등록 완료\n초기 포인트: 1,000P",
                                "신규 사용자 등록", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return UsingPoint.GetPoint(phone);
        }

        private void UpdatePhoneDisplay()
        {
            textBox1.Text = FormatPhoneNumber(textBox1.Text);
        }

        private string FormatPhoneNumber(string digits)
        {
            digits = new string(digits.Where(char.IsDigit).ToArray());

            if (digits.Length <= 3)
                return digits;
            else if (digits.Length <= 7)
                return digits.Substring(0, 3) + "-" + digits.Substring(3);
            else if (digits.Length <= 11)
                return digits.Substring(0, 3) + "-" + digits.Substring(3, 4) + "-" + digits.Substring(7);
            else
                return digits.Substring(0, 3) + "-" + digits.Substring(3, 4) + "-" + digits.Substring(7, 4);
        }

        private void AddDigit(string digit)
        {
            string digits = new string(textBox1.Text.Where(char.IsDigit).ToArray());
            digits += digit;
            textBox1.Text = FormatPhoneNumber(digits);
        }

        private void RemoveLastText()
        {
            if (textBox1.Text.Length > 3)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                UpdatePhoneDisplay();
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^(010)(-?\d{4})(-?\d{4})$";
            return System.Text.RegularExpressions.Regex.IsMatch(phone, pattern);
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
        private void ClearButton_Click(object sender, EventArgs e) { textBox1.Text = "010 - "; }
        private void button0_Click(object sender, EventArgs e) { AddDigit("0"); }
        private void EraseButton_Click(object sender, EventArgs e) { RemoveLastText(); }
        private void NotsaveButton_Click(object sender, EventArgs e) {
            inactivityTimer.Stop();
            PaymentcompletedUI form3 = new PaymentcompletedUI(0, PaymentAmount, 0, previousCartForm);
            var result = form3.ShowDialog();
            form3.FormClosed += (s, args) => Application.Exit();
            this.DialogResult = DialogResult.OK; // PaymentUI로 OK 반환
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            phone = textBox1.Text.Trim();
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("전화번호 형식이 올바르지 않습니다.\n예: 010-1234-5678",
                                "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FindPoint(phone);
            UsingPoint.SetPhoneNumber(phone);
            int point = UsingPoint.FindPoint(phone);
            UsingPoint.SetPayment(PaymentAmount);

            UsePointUI form2 = new UsePointUI(point, PaymentAmount, phone, previousCartForm);
            var result = form2.ShowDialog();
            form2.FormClosed += (s, args) => Application.Exit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SavePointUI_Load(object sender, EventArgs e)
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
                previousCartForm.InactivityTimer_Tick(sender, e);
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
