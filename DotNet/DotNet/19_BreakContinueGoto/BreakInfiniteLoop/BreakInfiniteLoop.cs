using System;

class BreakInfiniteLoop
{
    static void Main()
    {
        int number = 0;

        while (true) // 무한 루프
        {
            Console.WriteLine(++number);

            if (number >= 5)
            {
                break; // break 문으로 무한 루프 빠져 나오기 
            }
        }
    }
}
