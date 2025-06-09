using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace KioskProject
{
    public class OrderInfo
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }


        private static string connStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234;";

        public int SaveToDatabase()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO `order` (orderId, orderDate, totalamount) VALUES (@id, @date, @total)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", OrderId);
                    cmd.Parameters.AddWithValue("@date", OrderDate);
                    cmd.Parameters.AddWithValue("@total", TotalAmount);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        // 최근 INSERT된 PK값 가져옴
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        this.OrderId = Convert.ToInt32(cmd.ExecuteScalar());
                        return this.OrderId;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public static List<OrderInfo> GetAllOrders()
        {
            var orders = new List<OrderInfo>();

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT orderDate, totalamount, orderData FROM `order`";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new OrderInfo
                        {
                            OrderDate = reader.GetDateTime("orderDate"),
                            TotalAmount = reader.GetInt32("totalamount"),
                        });
                    }
                }
            }

            return orders;
        }
    }
}