class 알고리즘_배열채우기_기본
{
    static void Main()
    {
        int[,] arr = new int[5, 5];
        int value = 0;

        // 배열 기본 채우기
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = ++value; // 1부터 25까지 값 대입
            }
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
