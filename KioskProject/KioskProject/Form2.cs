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
    public partial class Form2 : Form
    {
        private int _paymentAmount;
        private int _Point;
        private static int _savePoint;
        private static int _UsePoint;
        private static int _finalPoint;
        private  static string phonenumber;
        public static Form2 Instance;
        public Form2(int remainingPoint, int paymentAmount, string number)
        {
            InitializeComponent();
            Instance = this;
            _paymentAmount = paymentAmount;
            _savePoint = (int)(paymentAmount * 0.05);
            _Point = remainingPoint;
            phonenumber = number;

            label3.Text = $"{paymentAmount:N0}원";
            label5.Text = $"{remainingPoint:N0}P";
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static int UsePoint(int used)
        {

            string cleaned = Instance.label5.Text.Replace("P", "").Replace(",", "").Trim();
            int Point = int.Parse(cleaned);
            _UsePoint = used;
            int _UsedPoint = Point - used;
            UpdatePoint(_UsedPoint);
            return _UsedPoint;
        }
        public static int AddPoint(int save)
        {
            _savePoint = save;
            if (save < 0) save = 0; // 음수 적립 방지
            _finalPoint = Form1.GetPoint(phonenumber) + _savePoint;
            return _finalPoint;
        }

        public static void UpdatePoint(int Point)
        {
            string connStr = Form1.DBConfig.ConnStr;

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE user SET point = @point WHERE number = @phone";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@point", Point);
                    cmd.Parameters.AddWithValue("@phone", phonenumber);  // static 변수 그대로 사용
                    cmd.ExecuteNonQuery();
                }
            }
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
        private void button1_Click(object sender, EventArgs e){AddDigit("1");}
        private void button2_Click(object sender, EventArgs e){AddDigit("2");}
        private void button3_Click(object sender, EventArgs e){AddDigit("3");}
        private void button4_Click(object sender, EventArgs e){AddDigit("4");}
        private void button5_Click(object sender, EventArgs e){AddDigit("5");}
        private void button6_Click(object sender, EventArgs e){AddDigit("6");}
        private void button7_Click(object sender, EventArgs e){AddDigit("7");}
        private void button8_Click(object sender, EventArgs e){AddDigit("8");}
        private void button9_Click(object sender, EventArgs e){AddDigit("9");}
        private void button0_Click(object sender, EventArgs e){AddDigit("0");}
        private void Clearbutton_Click(object sender, EventArgs e){textBox1.Text = "";}
        private void Erasebutton_Click(object sender, EventArgs e){RemoveLastText();}

        private void Closebutton_Click(object sender, EventArgs e) {
            _UsePoint = 0;
            Form3 form3 = new Form3(_savePoint, _paymentAmount, _UsePoint);
            form3.FormClosed += (s, args) => Application.Exit();
            form3.Show();
        }
        private void usePointbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.Replace(",", "").Trim(), out int used))
            {
                int remainingPoint = UsePoint(used);
                int remainingPayment = _paymentAmount - used;
                MessageBox.Show(
                    $"포인트 {used:N0}P를 사용하였습니다.\n" +
                    $"잔여 포인트: {remainingPoint:N0}P\n" +
                    $"남은 결제 금액: {remainingPayment:N0}원",
                    "포인트 사용 완료",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information 
                );
                _UsePoint = int.Parse(textBox1.Text);
                Form3 form3 = new Form3(_savePoint, remainingPayment, _UsePoint);
                form3.FormClosed += (s, args) => Application.Exit();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("사용할 포인트를 숫자로 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
