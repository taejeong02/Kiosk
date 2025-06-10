using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject
{
    internal class AdminLoginControl
    {
        private Timer _timer;
        private int _timeLeft;
        private Form _loginForm;
        private Label _timerLabel;

        public AdminLoginControl(Form loginForm, Label timerLabel)
        {
            _loginForm = loginForm;
            _timerLabel = timerLabel;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }

        public bool admin_Login(string ID, string PW) // 로그인 함수
        {
            adminDB db = new adminDB(); // db클래스 객체 생성
            bool id_status = db.FindAdminById(ID); // db클래스의 FindAdminById함수 호출 => id 존재 여부 확인 있으면 id_status=true
            bool pw_status; // 비밀번호 상태여부를 저장할 bool형 변수

            if (id_status == true) // adminLogin 함수를 호출하면 위 id_status부분 FindAdminById 함수가 실행됨.
                                   // 해당 함수의 결과 분기는 id 존재 여부, id가 존재하면 (id_status=true)
            {
                pw_status = db.validateAdminAccount(ID, PW); // db에 저장된 id와 pw가 일치하는지 검사하는 함수 => 마찬가지로
                // 일치하면 true, 아니면 false
                if (pw_status == false)
                {
                    return false; // adminLogin함수의 반환값이 false => 로그인UI에서 보면 if else 문 있는데 else문으로 넘어가서 로그인 실패
                }
                else
                {
                    return pw_status; // pw_status의 값이 true이므로 true를 반환하기때문에 로그인ui로 true가 넘어가서 로그인 성공
                }
            }
            else  // id pw 둘다 일치 하지 않는 경우에 이 분기로 넘어오게됨
            {
                MessageBox.Show("아이디가 존재하지 않습니다.");
                return false;
            }
        }

        public void StartCountdown(int seconds)
        {
            _timeLeft = seconds;
            _timerLabel.Text = _timeLeft.ToString();
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            _timerLabel.Text = _timeLeft.ToString();
            
            
            if (_timeLeft <= 0)
            {
                _timer.Stop();
                MessageBox.Show("시간 초과. 폼을 닫습니다.");
                _loginForm.Close();
            }
        }

        public void StopTimer()
        {
            if (_timer != null && _timer.Enabled)
            {
                _timer.Stop();
            }
        }
    }
}