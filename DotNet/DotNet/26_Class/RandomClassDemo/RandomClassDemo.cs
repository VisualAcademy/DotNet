using System;

class RandomClassDemo
{
    static void Main()
    {
        Console.Write("이번 주의 로또: ");
        Random ran = new Random();
        int[] arr = new int[6]; // 6개 데이터
        int temp = 0;
        for (int i = 0; i < 6; i++)
        {
            temp = ran.Next(45) + 1; // 1 ~ 45까지
            bool flag = false;
            if (i > 0 && i < 6)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[j] == temp)
                    {
                        flag = true; // 중복되면, true로 설정        
                    }
                }
            }
            if (flag)
            {
                --i; // 중복되었다면, 현재 인덱스를 재 반복     
            }
            else
            {
                arr[i] = temp; // 중복된 데이터가 없다면, 저장
            }
        }
        for (int i = 0; i < 6; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }
}
