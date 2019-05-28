//[?] 리스트(배열, 컬렉션)
using System;

class ListDemo
{
    static void Main()
    {
        string[] colors = { "red", "green", "blue" };
        Console.WriteLine(colors[0]); // red
        Console.WriteLine(colors[1]); // green
        Console.WriteLine(colors[2]); // blue

        Console.WriteLine("요소 수: {0}", colors.Length); // 3
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }
    }
}
