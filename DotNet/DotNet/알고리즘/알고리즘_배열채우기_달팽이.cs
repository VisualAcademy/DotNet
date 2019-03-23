class 알고리즘_배열채우기_달팽이
{
    static void Main()
    {
        int[,] arr = new int[6,6];

        int num = 0; // 1부터 25까지의 배열에 저장할 값 증가 
        int s = 1; // 스위치 변수(1 또는 -1 토글)
        int p = 1;
        int q = 0;
        int k = 5;

        while (true)
        {
            // 열 증감
            for (int i = 0; i < k; i++)
            {
                num = num + 1;
                q = q + s; 
                arr[p, q] = num;
            }

            k = k - 1;

            if (k == 0)
            {
                break;
            }

            // 행 증감
            for (int i = 0; i < k; i++)
            {
                num = num + 1;
                p = p + s;
                arr[p, q] = num;
            }

            s = s * (-1); // 스위치 변수 토글 
        }
                
        // 배열의 내용 출력
        System.Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                System.Console.Write("{0}\t", arr[i,j]);
            }
            System.Console.WriteLine();
        }
    }
}
