using System;

class ArrayConvertAll
{
    static void Main()
    {
        string[] strArr = { "10", "20", "30" };

        // 문자열 배열을 정수형 배열로 변경
        int[] intArr = Array.ConvertAll(strArr, int.Parse);

        foreach (var number in intArr)
        {
            Console.WriteLine(number);
        }
    }
}
