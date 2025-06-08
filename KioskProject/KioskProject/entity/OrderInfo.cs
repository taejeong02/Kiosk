using System;
using MySql.Data.MySqlClient;

namespace KioskProject
{
    public class OrderInfo
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string OrderData { get; set; }

        private static string connStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234;";

        public bool SaveToDatabase()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO `order` (orderDate, totalamount, orderData) VALUES (@date, @total, @data)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", OrderDate);
                    cmd.Parameters.AddWithValue("@total", TotalAmount);
                    cmd.Parameters.AddWithValue("@data", OrderData);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}