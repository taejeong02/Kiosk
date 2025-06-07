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

namespace save_Point_UI
{
    public partial class Form1 : Form
    {
        public static class DBConfig
        {
            public static readonly string ConnStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234;";
        }

        public Form1()
        {
            InitializeComponent();
            int PaymentAmount = 80000;
            textBox1.Text = "010 - ";
            label3.Text = ((int)(PaymentAmount * 0.05)).ToString("N0") + "P";
        }

        public bool IsExistingUser(string phone)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM user WHERE number = @phone";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static int GetPoint(string phone)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "SELECT point FROM user WHERE number = @phone";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    var result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);
                    else
                        return -1;
                }
            }
        }

        public int FindPoint(string phone)
        {
            if (!IsExistingUser(phone))
                InsertUser(phone);

            return GetPoint(phone);
        }

        private void InsertUser(string phone)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "INSERT INTO user (number, point) VALUES (@phone, 1000)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@point", 1000);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"[신규등록] {phone} 사용자 등록 완료\n초기 포인트: 1,000P",
                "신규 사용자 등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            int point = FindPoint(phone);
            int paymentAmount = 80000;

            Form2 form2 = new Form2(point, paymentAmount, phone);
            form2.FormClosed += (s, args) => Application.Exit();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
