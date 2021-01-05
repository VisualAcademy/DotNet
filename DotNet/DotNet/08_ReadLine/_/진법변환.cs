using System;

namespace 진법변환
{
    class 진법변환
    {
        static void Main(string[] args)
        {
            // 10진수 10을 2진수로 변경하면 1010
            Console.WriteLine($"10 : {Convert.ToString(10, 2)}"); // 8421 => 1010

            // 2진수 1010을 10진수로 변경하면 10
            Console.WriteLine($"1010 : {Convert.ToInt32("1010", 2)}"); // 10
        }
    }
}
