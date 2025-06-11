using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskProject
{
    internal class SalesInquiry
    {
        public static (int total, int year, int month, int day) CalculateSales(List<OrderInfo> orders)
        {
            int total = 0, year = 0, month = 0, day = 0;
            DateTime now = DateTime.Now;

            foreach (var order in orders)
            {
                int amount = order.TotalAmount;
                DateTime date = order.OrderDate;

                total += amount;

                if (date.Year == now.Year)
                {
                    year += amount;

                    if (date.Month == now.Month)
                    {
                        month += amount;

                        if (date.Day == now.Day)
                        {
                            day += amount;
                        }
                    }
                }
            }

            return (total, year, month, day);
        }

        public static bool TryCalculateSales(out (int total, int year, int month, int day) sales)
        {
            sales = (0, 0, 0, 0);

            try
            {
                List<OrderInfo> orders = OrderInfo.GetAllOrders();
                sales = CalculateSales(orders);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] 매출 조회 실패: {ex.Message}");
                return false;
            }
        }
    }
}
