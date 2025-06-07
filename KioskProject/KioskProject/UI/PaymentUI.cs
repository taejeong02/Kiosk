using KioskProject;
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
using MetroFramework.Forms;


namespace KioskProject
{
    public partial class PaymentUI : MetroFramework.Forms.MetroForm
    {
        private bool[] isPaid; // 인원 수만큼 상태 저장
        private int totalAmount = 0;
        private int numberOfPeople = 1;

        private CartUI previousCartForm;

        public PaymentUI(int totalAmount, CartUI cartForm)
        {
            InitializeComponent();

            this.totalAmount = totalAmount;
            this.previousCartForm = cartForm;

            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PerPersonAmount.Text = $"{totalAmount}원"; // 총 금액 그대로 표시
            labelCount.Text = $"{numberOfPeople}명";
            UpdatePersonPanels();

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
            MessageBox.Show("결제가 취소되었습니다.");

        }

        private void ChangePaymentMethod_btn_Click(object sender, EventArgs e) //결제 수단 변경 
        {
            this.Close();                 // PaymentUI 닫고
            previousCartForm.Show();     // CartUI 다시 보여줌 (숨겨진 상태에서 복귀)
        }

        private Panel CreatePersonPanel(int index, int amount)
        {
            Panel panel = new Panel
            {
                Size = new Size(120, 100),
                BackColor = Color.White,

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
                BackColor = Color.LightBlue,
                FlatStyle = FlatStyle.Flat
            };
            btnPay.FlatAppearance.BorderSize = 1; // ← 테두리 두께 설정
            btnPay.FlatAppearance.BorderColor = Color.Black; // ← 테두리 색 설정

            // 버튼 클릭 이벤트 연결
            btnPay.Click += (sender, e) =>
            {
                if (isPaid[index - 1]) // 이미 결제함
                {
                    MessageBox.Show($"{index}번 손님은 이미 결제하셨습니다.", "중복 결제", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                isPaid[index - 1] = true;
                btnPay.Enabled = false;
                btnPay.BackColor = Color.Gray;
                btnPay.Text = "완료";

                MessageBox.Show($"{index}번 손님 결제 완료!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 모두 결제 완료됐는지 확인
                if (isPaid.All(x => x))
                {
                    MessageBox.Show("모든 결제가 완료되었습니다!", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 👉 새로운 폼 띄우기 (예: ReceiptUI)
                    PointUI receipt = new PointUI(); // ← 포인트 폼
                    receipt.Show();

                    this.Close(); // PaymentUI 닫기
                }
            };

            panel.Controls.Add(lblIndex);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(btnPay);

            return panel;
        }

        // 패널 전체 업데이트
        private void UpdatePersonPanels()
        {
            isPaid = new bool[numberOfPeople];
            flowLayoutPanel1.Controls.Clear();

            int perAmount = (numberOfPeople == 0) ? 0 : totalAmount / numberOfPeople;
            PerPersonAmount.Text = $"{perAmount}원";

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Panel panel = CreatePersonPanel(i, perAmount);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}
