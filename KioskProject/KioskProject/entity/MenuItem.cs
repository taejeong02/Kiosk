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

        public static List<MenuItem> GetMenuItemsFromDB(string categoryName)
        {
            List<MenuItem> items = new List<MenuItem>();
            string connStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234";

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
        public static List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();
            string connStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234";

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
    public class MyMenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public bool IsSpicyOptionEnabled { get; set; }
        public bool IsSizeOptionEnabled { get; set; }

        public MyMenuItem(string name, int price, string category, bool isSpicy, bool isSize)
        {
            Name = name;
            Price = price;
            Category = category;
            IsSpicyOptionEnabled = isSpicy;
            IsSizeOptionEnabled = isSize;
        }
    }
}
