using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;

namespace KioskProject
{
    public class MenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public bool IsSizeOptionEnabled { get; set; }
        public bool IsSpicyOptionEnabled { get; set; }

        // DB에서 메뉴 불러오기
        public static List<MenuItem> GetMenuItemsFromDB(string categoryName)
        {
            List<MenuItem> items = new List<MenuItem>();
            string connStr = "server=34.45.48.0;database=Kiosk;uid=appuser;pwd=KioskProjectghguddeumk2";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM menu WHERE ProductCategory = @cat";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cat", categoryName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new MenuItem
                            {
                                Name = reader["ProductName"].ToString(),
                                Price = int.Parse(reader["ProductPrice"].ToString()),
                                Category = reader["ProductCategory"].ToString(),
                                IsSizeOptionEnabled = Convert.ToInt32(reader["IsSizeOptionEnabled"]) == 1,
                                IsSpicyOptionEnabled = Convert.ToInt32(reader["IsSpicyOptionEnabled"]) == 1
                            });
                        }
                    }
                }
            }
            return items;
        }

        // DB에서 카테고리 불러오기
        public static List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();
            string connStr = "server=34.45.48.0;database=Kiosk;uid=appuser;pwd=KioskProjectghguddeumk2";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT DISTINCT ProductCategory FROM menu";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(reader["ProductCategory"].ToString());
                    }
                }
            }
            return categories;
        }
    }
}
