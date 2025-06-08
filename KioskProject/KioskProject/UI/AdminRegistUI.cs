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
    public partial class AdminRegistUI : MetroFramework.Forms.MetroForm
    {
        public AdminRegistUI()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string ID = registerID_txtbox.Text; // 로그인 ui와 마찬가지로 텍스트 박스에 입력된 문자를 string 변수에 저장
            string PW = registerPW_txtbox.Text;
            
            AdminRegistControl adminRegist = new AdminRegistControl(); // adminregistControl 객체 생성
            adminRegist.admin_account_SaverDB(ID, PW); // adminregistControl의 amdin_account_saveDB함수의 인자에
                                                       // 위의 string변수 2개를 인자로 넘김
            this.Close();
        }
    }
}
