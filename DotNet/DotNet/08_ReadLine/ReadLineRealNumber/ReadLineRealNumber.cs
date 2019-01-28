using System;

class ReadLineRealNumber
{
    static void Main()
    {
        Console.Write("실수를 입력하세요: ");
        string input = Console.ReadLine(); // "3.14"를 입력한다면 
        double PI = Convert.ToDouble(input); // "3.14"를 3.14로 변경
        Console.WriteLine(PI); // 3.14
    }
}
