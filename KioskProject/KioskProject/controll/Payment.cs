using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static KioskProject.CartUI;

namespace KioskProject
{
    public class Payment
    {
        private int totalAmount;
        private int numberOfPeople;

        public Payment()
        {
            totalAmount = 0;
            numberOfPeople = 0;
        }

        public void CancelPayment(int orderId)
        {
            Console.WriteLine($"주문 번호 {orderId}의 결제가 취소되었습니다.");
        }

        public void RefundPayment(int orderId)
        {
            Console.WriteLine($"주문 번호 {orderId}에 대해 환불이 처리되었습니다.");
        }

        public bool Pay(int amount)
        {
            totalAmount += amount;
            numberOfPeople++;
            Console.WriteLine($"{amount}원이 결제 되었습니다.");
            return true;
        }

        // 결제 완료 시 주문 저장
        public int SaveOrderInfo(string orderData)
        {
            OrderInfo order = new OrderInfo
            {
                OrderDate = DateTime.Now,
                TotalAmount = totalAmount,
                OrderData = orderData
            };

            return order.SaveToDatabase();
        }

        // 현금 결제 승인 처리
        public void ApproveCashPayment(List<string> cartItems)
        {
            // 결제 승인 후, OrderDetails 폼 실행
            int totalPrice = totalAmount; // 총 금액
            OrderDetails orderDetails = new OrderDetails(cartItems, totalPrice);
            orderDetails.Show();  // 결제 내역을 표시할 폼 실행

            // 결제 완료 후 카트 데이터를 비우고, ShopPacking으로 돌아가도록 처리
            StaticCartData.Clear();
            Console.WriteLine("현금 결제 승인 완료");
        }
    }
}
