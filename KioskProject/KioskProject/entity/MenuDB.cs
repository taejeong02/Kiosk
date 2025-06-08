using MySql.Data.MySqlClient;
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
}
