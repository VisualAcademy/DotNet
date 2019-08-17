//[?] 1부터 1,000까지의 정수 중 13의 배수의 개수(건수, 횟수)
using System;
using System.Linq;

/// <summary>
/// 개수 알고리즘(Count Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 개수 
/// </summary>
class CountAlgorithm
{
    static void Main()
    {
        //[1] Input: 1부터 1,000까지의 데이터 
        var numbers = Enumerable.Range(1, 1_000).ToArray();
        int count = default; // 개수를 저장할 변수는 0으로 초기화

        //[2] Process: 개수 알고리즘 영역: 주어진 범위에 주어진 조건(필터링)
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 13 == 0) // 13의 배수면 개수 증가
            {
                //count = count + 1;
                //count += 1;
                count++; // COUNT
            }
        }

        //[3] Output
        Console.WriteLine($"1부터 1,000까지의 정수 중 13의 배수의 개수: {count}");
    }
}

//Enumerable.Range(1, 1_000).ToArray().Where(n => n % 13 == 0).Count()
//76
//Enumerable.Range(1, 1_000).ToArray().Count(n => n % 13 == 0)
//76
