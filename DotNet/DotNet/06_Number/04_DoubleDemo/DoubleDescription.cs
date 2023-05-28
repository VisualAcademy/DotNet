using System;

class DoubleDescription
{
    static void Main()
    {
        // 'd' 접미사 없음
        double PI = 3.141592;
        Console.WriteLine("'d' 접미사 없는 PI의 값: " + PI);

        // 'd' 접미사 포함
        double PIWithSuffix = 3.141592d;
        Console.WriteLine("'d' 접미사가 있는 PI의 값: " + PIWithSuffix);
    }
}
