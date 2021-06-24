using System;

class 알고리즘_이진검색
{
    static void Main()
    {
        //[1] Input
        int[] intNum = { 1, 2, 3, 4, 5, 6, 7 };
        int key = 5;
        int low, high, mid, flag;
        //[2] Process
        low = 0;
        high = intNum.Length - 1;
        flag = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            //Console.WriteLine("비교");
            if (key == intNum[mid])
            {
                flag = 1;
                break;
            }
            if (key < intNum[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        //[3] Output
        if (flag == 1)
        {
            Console.WriteLine("찾았습니다.");
        }
        else
        {
            Console.WriteLine("못찾았습니다.");
        }
    }
}
