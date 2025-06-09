using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskProject.entity
{
    internal class UserDB
    {
        public static class DBConfig
        {
            public static readonly string ConnStr = "Server=127.0.0.1;Port=3306;Database=Kiosk;Uid=root;Pwd=123456;";
        }

        public static bool IsExistingUser(string phone)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM user WHERE number = @phone";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static void InsertUser(string phone)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "INSERT INTO user (number, point) VALUES (@phone, 1000)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static int GetPoint(string phone)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "SELECT point FROM user WHERE number = @phone";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);
                    else
                        return -1;
                }
            }
        }
        public static void UpdatePoint(string phone, int point)
        {
            using (var conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "UPDATE user SET point = @point WHERE number = @phone";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@point", point);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
