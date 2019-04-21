using System;
using System.Collections;

class YieldDemo
{
    //[1] yield 키워드를 사용하여 데이터를 단계별로 반환: 1부터 5까지 반복해서 반환
    static IEnumerable GetNumbers()
    {
        yield return 1; // 각각 따로따로 호출 가능
        yield return 2;
        for (int i = 3; i <= 5; i++)
        {
            yield return i; // 반복해서 호출 가능
        }
    }

    static void Main()
    {
        //[2] IEnumerable 반환값을 갖는 반복기는 foreach 문으로 호출해서 반복 사용
        foreach (int num in GetNumbers())
        {
            Console.Write($"{num}\t", num);
        }
        Console.WriteLine();
    }
}
