using System;

public class ForSquare
{
    static void Main()
    {
        // 바깥쪽 for 문: 행 반복
        for (int i = 1; i <= 3; i++)
        {
            // 안쪽 for 문: 열 반복
            for (int j = 1; j <= 3; j++)
            {
                Console.Write("*"); // 별 모양 출력 
            }
            Console.WriteLine(); // 한 행 반복 후 줄바꿈 
        }
    }
}
