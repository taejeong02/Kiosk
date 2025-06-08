using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KioskProject
{
    public static class UsingPoint
    {
        private static int _paymentAmount;
        private static int _Point;
        private static int _UsePoint;
        private static int _savePoint;
        private static int _finalPoint;
        private static string _phoneNumber;
        public static class DBConfig
        {
            public static readonly string ConnStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234;";
        }
        public static void SetPhoneNumber(string phone)
        {
            _phoneNumber = phone;
        }
        public static void SetPayment(int payment)
        {
            _paymentAmount = payment;
        }
        public static void SetSavePoint(int savepoint)
        {
            _savePoint = savepoint;
        }
        public static void SetUsePoint(int usepoint)
        {
            _UsePoint = usepoint;
        }
        public static int FindPoint(string phone)
        {
            if (!IsExistingUser(phone))
                InsertUser(phone);

            return GetPoint(phone);
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
                    cmd.Parameters.AddWithValue("@point", 1000);
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
                    _Point = int.Parse(result.ToString());
                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);
                    else
                        return -1;
                }
            }
        }
        public static int UsePoint()
        {
            _Point = GetPoint(_phoneNumber);
            _finalPoint = _Point - _UsePoint;
            UpdatePoint();
            return _finalPoint;
        }
        public static int AddPoint()
        {
            if (_savePoint < 0) _savePoint = 0; // 음수 적립 방지
            _Point = GetPoint(_phoneNumber);
            _finalPoint = _Point + _savePoint;
            UpdatePoint();
            return _finalPoint;
        }
        public static void UpdatePoint()
        {
            string connStr = DBConfig.ConnStr;

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE user SET point = @point WHERE number = @phone";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@point", _finalPoint);
                    cmd.Parameters.AddWithValue("@phone", _phoneNumber);  // static 변수 그대로 사용
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
