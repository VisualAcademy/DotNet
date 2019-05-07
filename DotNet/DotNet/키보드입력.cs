using System;

class 키보드입력
{
    public static void Main()
    {
        Console.WriteLine("아무키나 누르세요.");
        // 키보드 키 값 입력
        ConsoleKeyInfo cki = Console.ReadKey(true);
        Console.WriteLine("{0}", cki.Key); // 키
        Console.WriteLine("{0}", cki.KeyChar); // 유니코드
        Console.WriteLine("{0}", cki.Modifiers); // Ctrl, Shift, Alt 조합
        if (cki.Key == ConsoleKey.Q)
        {
            Console.WriteLine("Q를 입력하셨군요...");
        }
    }
}
