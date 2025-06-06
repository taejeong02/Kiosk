using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskProject
{
    internal class adminDB
    {
        private string connectionString = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234"; // 로컬 호스트 데이터베이스 연결

        //string insertQuery = "INSERT INTO admin(admin_id, admin_pw, admin_uniquenum) VALUES('testID', 'testPW', '12345')";

        public bool validateAdminAccount(string id, string pw) // 데이터베이스 내부의 id, pw가 일치하는지 검사하는 함수
        {
            string query = "SELECT COUNT(*) FROM admin_db WHERE admin_id = @id AND admin_pw = @pw";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;  // ID와 PW 둘 다 일치하면 true
                }
            }
        }

        public void saveAdminAccount(string id, string pw, string Key) // 관리자 등록시 id, pw를 데이터베이스에 저장하는 함수
        {
            string query = "INSERT INTO admin_db (admin_id, admin_pw, admin_key) VALUES (@id, @pw, @ukey)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    cmd.Parameters.AddWithValue("@ukey", Key);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("관리자 계정 + 키 저장 성공");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("DB 저장 중 오류 발생: " + ex.Message);
                    }
                }
            }
        }

        public bool FindAdminById(string id) // 로그인시 id가 존재하는지 여부 확인
        {
            string query = "SELECT COUNT(*) FROM admin_db WHERE admin_id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;  // ID가 존재하면 true
                }
            }
        }
    }
}