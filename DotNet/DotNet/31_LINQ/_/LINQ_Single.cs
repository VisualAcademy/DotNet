using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Single
{
    static void Main()
    {
        List<string> colors = new List<string> { "Red", "Green", "Blue" };

        string red = colors.Single(c => c == "Red");

        Console.WriteLine(red); // "Red"

        try
        {
            // 없는 데이터 요청시 예외 발생
            string black = colors.Single(color => color == "Black");
        }
        catch (Exception ex)
        {
            Console.WriteLine("예외 발생: " + ex.Message);
        }
    }
}
