using System;

namespace MethodMyMath
{
    public class MyMath
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }
    }

    class MethodMyMath
    {
        static void Main()
        {
            int result = MyMath.Add(3, 5);
            Console.WriteLine($"결괏값: {result}"); // 8
        }
    }
}
