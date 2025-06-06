using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject
{
    internal class AdminRegistControl
    {
        public void admin_account_SaverDB(string id, string pw) // 계정을 db에 저장시키기 위한 함수 => 이 함수가 직접 저장시키는게 아님
        {                                   // 텍스트 박스에서 id와 pw를 넘겨받은 상태임을 인지
            adminDB db = new adminDB(); // db 객체 생성
            if (db.FindAdminById(id) == true)  // db클래스의 FindAdminById함수의 결과가 true일경우 ==> 아이디가 존재할 경우
            {
                MessageBox.Show("존재하는 ID입니다.");
            }
            else  // 아이디가 존재하지 않는 경우 ==> 회원가입이 가능한 id
            {
                string adminkey = admin_key_generation(); // 고유번호 생성 함수
                db.saveAdminAccount(id,pw,adminkey); // db클래스의 saveAdminAccount함수의 인자에 id, pw, 고유키 넘겨서 저장
                MessageBox.Show("관리자 등록이 완료되었습니다.");
                AdminRegistUI test = new AdminRegistUI(); // adminRegistUI 객체 생성 (레이블에 고유키 생성하는거 확인하려고 넣은 테스트 구문)
                test.metroLabel4.Text = adminkey; // 고유키 출력 테스트
            }
        }

        public string admin_key_generation() // 고유번호 생성 함수
        {
            const int keyLength = 10; // 고유번호 자리수 (10자리)
            StringBuilder sb = new StringBuilder(); // 결과 문자열을 조립할 stringbuilder객체
            using (var rng = RandomNumberGenerator.Create()) // 암호학적으로 안전한 난수 생성기 사용
            {
                byte[] buffer = new byte[1]; // 1 바이트 버퍼 (랜덤 바이트 1개 저장용)

                while (sb.Length < keyLength) // 고유키의 길이가 10자리에 도달할 때 까지 반복
                {
                    rng.GetBytes(buffer); // 랜덤 바이트 1개 생성해서 buffer[0]에 저장
                    int val = buffer[0] % 36; // 0~35 사이의 정수로 변환 (ASCII코드: 알파벳 36가지 => A-Z + 0-9)

                    if (val < 26)
                        sb.Append((char)('A' + val)); // 0-25 -> 대문자 A~Z
                    else
                        sb.Append((char)('0' + (val - 26))); // 0~9 -> 숫자 0~9
                }
            }

            return sb.ToString(); // 완성된 10자리 고유 키 문자열 반환
        }
    }
}