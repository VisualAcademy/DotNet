using System;
using System.Collections.Generic;
using System.Linq;

class LinqFirst
{
    static void Main()
    {
        List<string> colors = new List<string> { "Red", "Green", "Blue" };

        string red = colors.First(c => c == "Red");

        Console.WriteLine(red); // "Red"

        try
        {
            // 없는 데이터 요청시 예외 발생
            string black = colors.First(color => color == "Black");
            //// 없는 데이터 요청시 null 값 반환
            //string black = colors.FirstOrDefault(color => color == "Black");
        }
        catch (Exception ex)
        {
            Console.WriteLine("예외 발생: " + ex.Message);
        }
    }
}
//> List<string> colors = new List<string> { "Red", "Green", "Blue" };
//> colors.First(c => c == "Red")
//"Red"
//> colors.First(color => color == "Black")
//시퀀스에 일치하는 요소가 없습니다.
//  + System.Linq.Enumerable.First<TSource>(IEnumerable<TSource>, Func<TSource, bool>)
//> colors.FirstOrDefault(color => color == "Black")
//null
