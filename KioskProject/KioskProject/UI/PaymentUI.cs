using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Payment_UI
{
    public partial class PaymentUI : Form
    {
        private Payment payment = new Payment();
        private int totalAmount = 5000; //임의 금액으로 5000 값으로 함
        private int numberOfPeople = 1;
        

        public PaymentUI()
        {
            {
                InitializeComponent();

                this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click); // 인원수 증가 버튼 클릭 이벤트 연결 추가
                this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click); // 인원수 감소 버튼 클릭 이벤트 연결 추가
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PerPersonAmount.Text = $"{totalAmount}원"; // 임의 금액으로 5000원으로 표시
            labelCount.Text = $"{numberOfPeople}명";

            UpdatePersonPanels(); // 처음 로드 시 패널 생성
        }

        private void Minus_btn_Click(object sender, EventArgs e) // 총인원수 감소 버튼
        {
            if (numberOfPeople > 1)
            {
                numberOfPeople--;
                labelCount.Text = $"{numberOfPeople}명";
                UpdatePersonPanels();
            }
        }

        private void Plus_btn_Click(object sender, EventArgs e) // 총인원수 증가 버튼
        {
            numberOfPeople++;
            labelCount.Text = $"{numberOfPeople}명";
            UpdatePersonPanels();
        }

        private void CancelPaying_btn_Click(object sender, EventArgs e) // 결제 취소 버튼
        {
            payment.CancelPayment(1);
            MessageBox.Show("결제가 취소되었습니다.");

        }

        private void ChangePaymentMethod_btn_Click(object sender, EventArgs e) //결제 수단 변경 
        {

        }

        private Panel CreatePersonPanel(int index, int amount)
        {
            Panel panel = new Panel
            {
                Size = new Size(120, 100),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblIndex = new Label
            {
                Text = $"{index}",
                AutoSize = true,
                Location = new Point(50, 0),
                Font = new Font("맑은 고딕", 10, FontStyle.Bold)
            };

            Label lblPrice = new Label
            {
                Text = $"{amount}원",
                AutoSize = true,
                Location = new Point(30, 30),
                Font = new Font("맑은 고딕", 12, FontStyle.Bold)
            };

            Button btnPay = new Button
            {
                Text = "결제하기",
                Enabled = true,
                Size = new Size(80, 25),
                Location = new Point(20, 60),
                BackColor = Color.LightBlue
            };

            // 버튼 클릭 이벤트 연결
            btnPay.Click += (sender, e) =>
            {
                MessageBox.Show($"{index}번 인원이 {amount}원 결제 합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            panel.Controls.Add(lblIndex);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(btnPay);

            return panel;
        }

        // 패널 전체 업데이트
        private void UpdatePersonPanels()
        {
            flowLayoutPanel1.Controls.Clear(); // 기존 패널 제거 
            int.TryParse(Regex.Replace(PerPersonAmount.Text, @"\D", ""), out int perAmount);

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Panel panel = CreatePersonPanel(i, perAmount);
                flowLayoutPanel1.Controls.Add(panel);

            }
        }
    }
}
