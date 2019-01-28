using System;

class ParamsDemo
{
    static void Main()
    {
        // 가변 길이 매개 변수 => params
        Console.WriteLine(SumAll(3, 5)); // 8
        Console.WriteLine(SumAll(3, 5, 7)); // 15
        Console.WriteLine(SumAll(3, 5, 7, 9)); // 24
    }

    /// <summary>
    /// SumAll() 메서드는 정수 형식의 값을 가변 형식으로 받을 수 있음
    /// </summary>
    /// <param name="numbers">정수 배열</param>
    /// <returns>정수 배열의 합계</returns>
    static int SumAll(params int[] numbers) // [1] params로 여러 개의 매개 변수 받기 
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
