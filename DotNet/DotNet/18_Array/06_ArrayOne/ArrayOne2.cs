using System;

class ArrayOne2
{
    static void Main()
    {
        //[!] 1차원 배열 선언, 요소 생성, 초기화를 동시에...
        int[] intArray = new int[3] { 1, 2, 3 };

        //[1] for문 사용 출력: 정확하게 배열의 범위를 알고 있을 때
        for (int i = 0; i < 3; i++) // 배열 참조
        {
            Console.WriteLine($"{i}번째 인덱스: {intArray[i]}");
        }

        //[2] foreach문 사용 출력: intArray에 데이터가 있는 동안 반복
        foreach (int intValue in intArray)
        {
            Console.WriteLine("{0}", intValue);
        }
    }
}
