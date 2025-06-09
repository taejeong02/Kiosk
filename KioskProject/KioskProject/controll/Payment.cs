using System;

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

        public int GetTotalAmount() => totalAmount;
        public int GetNumberOfPeople() => numberOfPeople;

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

        //  결제 완료 시 주문 저장
        public int SaveOrder()
        {
            OrderInfo order = new OrderInfo
            {
                OrderDate = DateTime.Now,
                TotalAmount = totalAmount,
                
            };

            return order.SaveToDatabase();
        }
    }
}
