//[?] 리스트 제네릭 클래스: List<T> => List<int>, List<string>, List<object>
using System;
using System.Collections.Generic;

class ListOfString
{
    static void Main()
    {
        //[0] 제네릭 리스트 사용을 위한 인스턴스 생성 및 샘플 데이터 입력
        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        //[1] for 문으로 출력 예
        for (int i = 0; i < colors.Count; i++)
        {
            Console.Write($"{colors[i]}\t");
        }
        Console.WriteLine();

        //[2] foreach 문으로 출력 예
        foreach (var color in colors)
        {
            Console.Write($"{color}\t");
        }
        Console.WriteLine();
    }
}
