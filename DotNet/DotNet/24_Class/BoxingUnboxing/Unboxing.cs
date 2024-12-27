using System;

class Unboxing
{
    static void Main()
    {
        object o = 1234;        // 박싱된 정수를 포함하는 개체 생성
        int i = (int)o;         // 언박싱: 참조 형식을 값 형식으로 변환
        Console.WriteLine(i);   // 1234
    }
}
