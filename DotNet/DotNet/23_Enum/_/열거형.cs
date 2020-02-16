// 열거형: 하나의 이름으로 여러 개의 상수를 묶어서 관리
// 온라인 쇼핑몰
// 결제방법: 온라인입금, 신용카드, 포인트결제
// 주문상태: 신규주문, 주문확인, 주문취소
using System;

namespace 열거형
{
    public enum 결제방법
    {
        온라인입금,      // 0
        신용카드,       // 1
        계좌이체        // 2
    }

    public enum 주문상태
    {
        신규주문,               // 0
        주문확인,               // 1
        주문취소 = 9,           // 9
        배송중 = 3,             // 3
        배송완료 = 5,           // 5
        주문완료 = 7            // 7
    }

    class 열거형
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"결제방법 : {결제방법.계좌이체}, {(int)결제방법.계좌이체}");
            Console.WriteLine($"주문상태 : {주문상태.주문완료}, {(int)주문상태.주문완료}");

            결제방법 input = 결제방법.계좌이체;

            switch (input)
            {
                case 결제방법.온라인입금:
                    Console.WriteLine("온라인입금에 맞는 기능 수행");
                    break;
                case 결제방법.신용카드:
                    Console.WriteLine("신용카드에 맞는 기능 수행");
                    break;
                case 결제방법.계좌이체:
                    Console.WriteLine("계좌이체에 맞는 기능 수행");
                    break;
                default:
                    Console.WriteLine("에러/경고");
                    break;
            }
        }
    }
}
