// <예제> 지정된 열거형의 상수 리스트를 배열로 가져오기: EnumGetNames.cs
using System;

class EnumGetNames
{
    static void Main()
    {
        // ConsoleColor 열거형의 Type을 cc 변수에 저장
        Type cc = typeof(ConsoleColor);
        
        // 모든 색상 이름을 반환
        string[] colors = Enum.GetNames(cc);

        // 출력
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }
    }
}
