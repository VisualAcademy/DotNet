using System;

class ArrayEmpty
{
    static void Main(string[] args)
    {
        // 빈 배열 선언
        string[] authors = { };
        if (authors.Length > 0)
        {
            Console.WriteLine($"글쓴이가 {authors.Length}명 있습니다.");
        }
        else
        {
            Console.WriteLine($"글쓴이가 아무도 없습니다.");
        }
    }
}
