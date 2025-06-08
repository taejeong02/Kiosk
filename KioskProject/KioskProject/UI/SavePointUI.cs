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
    public partial class Form1 : Form
    {
        public static int PaymentAmount;
        public Form1(int payment)
        {
            InitializeComponent();
            PaymentAmount = payment;
            textBox1.Text = "010 - ";
            label3.Text = ((int)(PaymentAmount * 0.05)).ToString("N0") + "P";
        }

        public int FindPoint(string phone)
        {
            if (!UsingPoint.IsExistingUser(phone))
                UsingPoint.InsertUser(phone);
            MessageBox.Show($"[신규등록] {phone} 사용자 등록 완료\n초기 포인트: 1,000P",
                                "신규 사용자 등록", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void NotsaveButton_Click(object sender, EventArgs e) { this.Close(); }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text.Trim();
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("전화번호 형식이 올바르지 않습니다.\n예: 010-1234-5678",
                                "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UsingPoint.SetPhoneNumber(phone);
            int point = UsingPoint.FindPoint(phone);
            UsingPoint.SetPayment(PaymentAmount);

            UsingPointUI form2 = new UsingPointUI(point, PaymentAmount, phone);
            var result = form2.ShowDialog();
            form2.FormClosed += (s, args) => Application.Exit();
            this.DialogResult = DialogResult.OK; // PaymentUI로 OK 반환
            this.Close();
        }
    }
}
