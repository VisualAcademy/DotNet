//[!] 자리표시자의 형식 문자열에 따른 출력 결과 확인
using System;

class 플레이스홀더
{
    static void Main()
    {
        Console.WriteLine("{0}", 1234); // 1234
        Console.WriteLine("{0,10}", 1234); // 10칸 잡고 오른쪽 정렬
        Console.WriteLine("{0,-10}", 1234); // 10칸 잡고 왼쪽 정렬
        Console.WriteLine("{0,10:D}", 16); // 10진수: 16
        Console.WriteLine("{0,10:X}", 16); // 16진수: 10
        Console.WriteLine("{0,10:N}", 1234); // 콤마구분: 1,234.00
        Console.WriteLine("{0,10:C}", 1234); // 통화량: \1,234

        Console.WriteLine("{0,10:E}", 1234.5678); // 1.234568E+003
        Console.WriteLine("{0,10:F}", 1234.5678); // 1234.57
        Console.WriteLine("{0,10:G}", 1234.5678); // 1234.5678
    }
}
