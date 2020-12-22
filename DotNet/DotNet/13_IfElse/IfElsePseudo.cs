//[?] if와 else로 두 수의 차이를 양의 정수로 구하기 
using System;

class IfElsePseudo
{
    static void Main()
    {
        int diff = 0; // 두 수의 차이

        int first = 5;
        int second = 3;

        //int first = 3;
        //int second = 5;

        if (first > second)
        {
            diff = first - second; // first 변수가 더 큼
        }
        else
        {
            diff = second - first; // second 변수가 더 큼 
        }

        Console.WriteLine($"{first}와 {second}의 차이: {diff}");
    }
}
