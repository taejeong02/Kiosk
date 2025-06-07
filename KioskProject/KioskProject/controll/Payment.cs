using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Payment
{
    private int totalAmount;
    private int numberOfPeople;

    public Payment()
    {
        totalAmount = 0;
        numberOfPeople = 0;
    }

    // 총 금액 반환
    public int GetTotalAmount()
    {
        return totalAmount;
    }

    // 인원 수 반환
    public int GetNumberOfPeople()
    {
        return numberOfPeople;
    }

    // 결제 정보 저장
    public void SavePaymentInfo()
    {
        // 결제 정보 저장 로직
        Console.WriteLine("결제 정보가 저장되었습니다.");
    }

    // 결제 취소
    public void CancelPayment(int orderId)
    {
        //결제 취소 로직
        Console.WriteLine($"주문 번호 {orderId}의 결제가 취소되었습니다.");
    }

    // 환불 처리
    public void RefundPayment(int orderId)
    {
        //결제 환불 처리 로직
        Console.WriteLine($"주문 번호 {orderId}에 대해 환불이 처리되었습니다.");
    }

    // 결제 실행
    public bool Pay(int amount)
    {
        // 결제 로직
        totalAmount += amount;
        numberOfPeople++;
        Console.WriteLine($"{amount}원이 결제 되었습니다.");
        return true;
    }
}
