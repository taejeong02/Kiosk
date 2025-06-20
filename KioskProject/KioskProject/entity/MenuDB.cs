﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace KioskProject.entity
{
    internal class MenuDB
    {
        private string connectionString = "server=34.45.48.0;database=Kiosk;uid=appuser;pwd=KioskProjectghguddeumk2";

        public List<KioskAdminMenu.FoodItem> SelectAll()
        {
            List<KioskAdminMenu.FoodItem> items = new List<KioskAdminMenu.FoodItem>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM menu ORDER BY CAST(ProductID AS UNSIGNED)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new KioskAdminMenu.FoodItem
                    {
                        ProductID = reader["ProductID"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        ProductPrice = reader["ProductPrice"].ToString(),
                        ProductCategory = reader["ProductCategory"].ToString(),
                        IsSpicyOptionEnabled = Convert.ToInt32(reader["IsSpicyOptionEnabled"]),
                        IsSizeOptionEnabled = Convert.ToInt32(reader["IsSizeOptionEnabled"])
                    });
                }
            }
            return items;
        }

        public void Insert(KioskAdminMenu.FoodItem item)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO menu (ProductID, ProductName, ProductPrice, ProductCategory, IsSpicyOptionEnabled, IsSizeOptionEnabled) VALUES (@id, @name, @price, @category, @spicy, @size)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", item.ProductID);
                cmd.Parameters.AddWithValue("@name", item.ProductName);
                cmd.Parameters.AddWithValue("@price", item.ProductPrice);
                cmd.Parameters.AddWithValue("@category", item.ProductCategory);
                cmd.Parameters.AddWithValue("@spicy", item.IsSpicyOptionEnabled);
                cmd.Parameters.AddWithValue("@size", item.IsSizeOptionEnabled);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM menu WHERE ProductID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(KioskAdminMenu.FoodItem item)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE menu SET ProductName = @name, ProductPrice = @price, ProductCategory = @category, IsSpicyOptionEnabled = @spicy, IsSizeOptionEnabled = @size WHERE ProductID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", item.ProductID);
                cmd.Parameters.AddWithValue("@name", item.ProductName);
                cmd.Parameters.AddWithValue("@price", item.ProductPrice);
                cmd.Parameters.AddWithValue("@category", item.ProductCategory);
                cmd.Parameters.AddWithValue("@spicy", item.IsSpicyOptionEnabled);
                cmd.Parameters.AddWithValue("@size", item.IsSizeOptionEnabled);
                cmd.ExecuteNonQuery();
            }
        }
    }
    //OrderUI.cs랑 통신하는 부분
    public class MenuDataItem
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public bool IsSizeOptionEnabled { get; set; }
        public bool IsSpicyOptionEnabled { get; set; }

        // DB에서 메뉴 불러오기
        public static List<MenuDataItem> GetMenuItemsFromDB(string categoryName)
        {
            List<MenuDataItem> items = new List<MenuDataItem>();
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
                            items.Add(new MenuDataItem
                            {
                                ProductID = reader["ProductID"].ToString(),
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
