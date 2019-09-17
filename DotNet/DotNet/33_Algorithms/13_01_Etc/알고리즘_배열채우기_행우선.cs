class 알고리즘_배열채우기_행우선
{
    static void Main()
    {
        int[,] arr = new int[5, 5];
        int value = 0;
        int row = 0, col = 0;

        // 배열 채우기: 행 우선
        while (col < 5)
        {
            row = 0; 
            while (row < 5)
            {
                value = value + 1;
                arr[row, col] = value; 
                row = row + 1;
            }
            col = col + 1; 
        }

        // 배열 값 출력 
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write("{0,2} ", arr[i, j]);
            }
            System.Console.WriteLine();
        }
    }
}
