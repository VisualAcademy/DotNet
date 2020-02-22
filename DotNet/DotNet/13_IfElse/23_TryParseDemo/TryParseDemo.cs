// 특정 데이터형식으로 변환이 가능한지 판단
using System;

namespace TryParseDemo
{
    class TryParseDemo
    {
        static void Main(string[] args)
        {
            string data = "1234";

            int result;
            if (int.TryParse(data, out result))
            {
                Console.WriteLine("변환 가능: {0}", result);
            }
            else
            {
                Console.WriteLine("변환 불가");
            }

            double d;
            if (Double.TryParse(data, out d))
            {
                Console.WriteLine("변환 가능: {0}", d);
            }
        }
    }
}
