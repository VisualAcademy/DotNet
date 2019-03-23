//[?] 3차원 배열(층, 행, 열)
using System;

class ArrayThreeDescription
{
    static void Main()
    {
        //[1] 3차원 배열 선언
        string[,,] names = new string[2, 2, 2]; // 2*2*2=8

        //[2] 3차원 배열 초기화
        names[0, 0, 0] = "C#";
        names[0, 0, 1] = "ASP.NET";

        names[0, 1, 0] = "Windows Forms";
        names[0, 1, 1] = "WPF";

        names[1, 0, 0] = "Xamarin";
        names[1, 0, 1] = "Unity";

        names[1, 1, 0] = "UWP";
        names[1, 1, 1] = "Azure";

        //[3] 3차원 배열 사용
        Console.WriteLine("\n0층");
        Console.WriteLine($"{names[0, 0, 0],20}, {names[0, 0, 1],20}");
        Console.WriteLine($"{names[0, 1, 0],20}, {names[0, 1, 1],20}");

        Console.WriteLine("\n1층");
        Console.WriteLine($"{names[1, 0, 0],20}, {names[1, 0, 1],20}");
        Console.WriteLine($"{names[1, 1, 0],20}, {names[1, 1, 1],20}");
    }
}
