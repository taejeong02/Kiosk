using KioskProject;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class ReceiptControl
{
    private ShopPacking previousForm2;
    public static void ShowReceipt(int orderId, ShopPacking shopPackingForm)
    {
        // DB에서 주문 정보 읽기
        var orderInfo = LoadOrderInfo(orderId);

        if (orderInfo == null)
        {
            MessageBox.Show("주문 정보를 불러올 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var result = MessageBox.Show(
            "영수증을 출력하시겠습니까?",
            "영수증",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            string receiptText =
                $"주문번호: {orderInfo.OrderId}\n" +
                $"주문일자: {orderInfo.OrderDate}\n" +
                orderInfo.OrderData + "\n" +
                $"총 결제금액: {orderInfo.TotalAmount:N0}원";

            MessageBox.Show(receiptText, "영수증", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show($"주문번호: {orderInfo.OrderId}", "주문번호", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private static OrderInfo LoadOrderInfo(int orderId)
    {
        OrderInfo info = null;
        string connStr = "Server=34.45.48.0;Port=3306;Database=Kiosk;Uid=root;Pwd=admin1234;";
        using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT orderId, orderDate, totalamount, orderData FROM `order` WHERE orderId = @id";
            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        info = new OrderInfo
                        {
                            OrderId = reader.GetInt32(0),
                            OrderDate = reader.GetDateTime(1),
                            TotalAmount = reader.GetInt32(2),
                            OrderData = reader.GetString(3)
                        };
                    }
                }
            }
        }
        return info;
    }
}
