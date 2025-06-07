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


namespace KioskProject
{
    public partial class Payment : Form
    {
        private Payment payment = new Payment();
        private int totalAmount = 5000; //임의 금액으로 5000 값으로 함
        private int numberOfPeople = 1;

        public Payment()
        {
            InitializeComponent();

            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn.Click); //인원수 증가 버튼 클릭 이벤트 연결 추가
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn.Click); // 인원수 감소 버튼 클릭 이벤트 연결 추가

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Minus_btn = new System.Windows.Forms.Button();
            this.Plus_btn = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PerPersonAmount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.ChangePaymentMethod_btn = new System.Windows.Forms.Button();
            this.CancelPaying_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "총 인원 수:";
            // 
            // Minus_btn
            // 
            this.Minus_btn.Location = new System.Drawing.Point(124, 20);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.Size = new System.Drawing.Size(44, 34);
            this.Minus_btn.TabIndex = 1;
            this.Minus_btn.Text = "-";
            this.Minus_btn.UseVisualStyleBackColor = true;
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click);
            // 
            // Plus_btn
            // 
            this.Plus_btn.Location = new System.Drawing.Point(221, 20);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.Size = new System.Drawing.Size(44, 34);
            this.Plus_btn.TabIndex = 2;
            this.Plus_btn.Text = "+";
            this.Plus_btn.UseVisualStyleBackColor = true;
            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.labelCount.Location = new System.Drawing.Point(174, 21);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 25);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "1명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.label3.Location = new System.Drawing.Point(295, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "1인당 결제 금액 :";
            // 
            // PerPersonAmount
            // 
            this.PerPersonAmount.AutoSize = true;
            this.PerPersonAmount.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.PerPersonAmount.Location = new System.Drawing.Point(466, 22);
            this.PerPersonAmount.Name = "PerPersonAmount";
            this.PerPersonAmount.Size = new System.Drawing.Size(63, 25);
            this.PerPersonAmount.TabIndex = 5;
            this.PerPersonAmount.Text = "label6";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 729);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.button3.Location = new System.Drawing.Point(12, 807);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "포인트 조회 및 사용";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ChangePaymentMethod_btn
            // 
            this.ChangePaymentMethod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePaymentMethod_btn.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.ChangePaymentMethod_btn.Location = new System.Drawing.Point(308, 807);
            this.ChangePaymentMethod_btn.Name = "ChangePaymentMethod_btn";
            this.ChangePaymentMethod_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangePaymentMethod_btn.Size = new System.Drawing.Size(145, 42);
            this.ChangePaymentMethod_btn.TabIndex = 41;
            this.ChangePaymentMethod_btn.Text = "결제수단 변경";
            this.ChangePaymentMethod_btn.UseVisualStyleBackColor = true;
            this.ChangePaymentMethod_btn.Click += new System.EventHandler(this.ChangePaymentMethod_btn_Click);
            // 
            // CancelPaying_btn
            // 
            this.CancelPaying_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelPaying_btn.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.CancelPaying_btn.Location = new System.Drawing.Point(459, 807);
            this.CancelPaying_btn.Name = "CancelPaying_btn";
            this.CancelPaying_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelPaying_btn.Size = new System.Drawing.Size(112, 42);
            this.CancelPaying_btn.TabIndex = 42;
            this.CancelPaying_btn.Text = "결제 취소";
            this.CancelPaying_btn.UseVisualStyleBackColor = true;
            this.CancelPaying_btn.Click += new System.EventHandler(this.CancelPaying_btn_Click);
            // 
            // Payment
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.CancelPaying_btn);
            this.Controls.Add(this.ChangePaymentMethod_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PerPersonAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.Plus_btn);
            this.Controls.Add(this.Minus_btn);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PerPersonAmount.Text = $"{totalAmount}원"; // 임의 금액으로 5000원으로 표시
            labelCount.Text = $"{numberOfPeople}명";

            UpdatePersonPanels(); // 처음 로드 시 패널 생성
        }

        private void Minus_btn_Click(object sender, EventArgs e)
        {
            if (numberOfPeople > 1)
            {
                numberOfPeople--;
                labelCount.Text = $"{numberOfPeople}명";
                UpdatePersonPanels();
            }
        }

        private void Plus_btn_Click(object sender, EventArgs e)
        {
            numberOfPeople++;
            labelCount.Text = $"{numberOfPeople}명";
            UpdatePersonPanels();
        }

        private void CancelPaying_btn_Click(object sender, EventArgs e)
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
