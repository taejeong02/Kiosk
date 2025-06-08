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
    public partial class Select_Language : MetroFramework.Forms.MetroForm
    {
        public Select_Language()
        {
            InitializeComponent(); // 이하 이미지 버튼
            try
            {
                this.Korean.BackgroundImage = Image.FromFile("KoreanFlag.png");
                this.China.BackgroundImage = Image.FromFile("ChinaFlag.jpg");
                this.English.BackgroundImage = Image.FromFile("AmericaFlag.jpg");
                this.Japan.BackgroundImage = Image.FromFile("JapanFlag.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로딩 오류: " + ex.Message);
            }
        }

        int clickcount = 0; // 관리자창은 일반인이 접근하지 못하게끔 숨겨둬야함
                            // 클릭카운트를 두고 특정횟수이상 클릭하게 되면 관리자창에 접근할 수 있도록 되어잇음
        private void test_Click(object sender, EventArgs e)
        {
            clickcount++; // 클릭시 클릭카운트 횟수가 1씩 증가
            if (clickcount == 3) { // 3번 클릭시
                AdminLogin adminLogin = new AdminLogin(); // 관리자 폼 출력
                adminLogin.ShowDialog();
                clickcount = 0; // 클릭카운트 초기화
            }
        }

        private void Korean_Click(object sender, EventArgs e)
        {
            welcome_lbl.Text = "어서오세요.";
        }

        private void English_Click(object sender, EventArgs e)
        {
            welcome_lbl.Text = "Welcome";
        }

        private void China_Click(object sender, EventArgs e)
        {
            welcome_lbl.Text = "欢迎";
        }

        private void Japan_Click(object sender, EventArgs e)
        {
            welcome_lbl.Text = "ようこそ";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OrderUI orderui = new OrderUI(this); // 현재 폼 참조 전달
            orderui.FormClosed += (s, args) => Application.Exit();
            this.Hide(); // 현재 폼 숨김
            orderui.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OrderUI orderui = new OrderUI(this); // 현재 폼 참조 전달
            orderui.FormClosed += (s, args) => Application.Exit();
            this.Hide(); // 현재 폼 숨김
            orderui.Show();
        }

        private void Select_Language_Load(object sender, EventArgs e)
        {

        }
    }
}
