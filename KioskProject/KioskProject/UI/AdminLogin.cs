using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskProject;

namespace KioskProject
{
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        private AdminLoginControl loginControl;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string ID = adminId_txtBox.Text.Trim(); // 텍스트 박스에 입력된 문자를 각각의 string 변수에 저장
            string PW = adminPw_txtBox.Text.Trim();

            bool result = loginControl.admin_Login(ID, PW); // 로그인 함수에 인자(위의 string 변수)를 넣어 호출, 이후 반환값을 result에 저장

            if (result == true) 
            { 
                MessageBox.Show("로그인 성공");

                //foreach (Form form in Application.OpenForms)
                //{
                //    if (form is ShopPacking)
                //    {
                //        form.Hide();
                //        break;
                //    }
                //}
                KioskAdminMenu adminMenu = new KioskAdminMenu();
                adminMenu.Show();
                this.Close();
            } // 반환받은 result가 true
            // admin_Login 함수에 대한 자세한 설명은 adminlogincontrol에 상기
            else { MessageBox.Show("로그인 실패"); }
        }

        private void regist_btn_Click(object sender, EventArgs e)
        {
            AdminRegistUI registUI = new AdminRegistUI();
            registUI.ShowDialog();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            loginControl = new AdminLoginControl(this, logintimer_lbl);
            loginControl.StartCountdown(60);
        }
    }
}
