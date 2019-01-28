using System;

namespace Method_MyMath
{
    public class MyMath
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }
    }

    class Method_MyMath
    {
        static void Main()
        {
            int result = MyMath.Add(3, 5);
            Console.WriteLine($"결괏값: {result}"); // 8
        }
    }
}
