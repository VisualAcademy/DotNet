//[?] 2차원 배열: 행과 열로 이루어진 배열
using System;

class ArrayTwoDescription
{
    static void Main()
    {
        //[1] 2차원 배열 선언
        char[,] arr = new char[2, 2];

        //[2] 2차원 배열 초기화
        arr[0, 0] = 'A';
        arr[0, 1] = 'B';

        arr[1, 0] = 'C';
        arr[1, 1] = 'D';

        //[3] 2차원 배열 사용
        Console.WriteLine($"{arr[0, 0]}, {arr[0, 1]}");
        Console.WriteLine($"{arr[1, 0]}, {arr[1, 1]}");
    }
}
