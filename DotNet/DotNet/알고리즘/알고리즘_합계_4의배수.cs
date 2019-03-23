using System;

class 알고리즘_합계_4의배수
{
    static void Main()
    {
        int[] arr = { 8, 16, 15, 12, 17 }; 
        int sum = 0; // 합계 보관
        int rem = 0; // 나머지 값 임시 보관
        int i = 0; 

        do
        {
            rem = arr[i] % 4;       // 4로 나누었을 때 나머지 값 구하기 
            if (rem == 0)           // 4로 나누어 떨어지면 나머지가 0
            {
                sum = sum + arr[i]; // 4의 배수의 합
            }
            i = i + 1; 
        } while (i < 5);

        Console.WriteLine("4의 배수의 합: {0}", sum);
    }
}
