// Any() 확장 메서드: 시퀀스의 하나의 요소라도 조건을 만족 하는지 여부
using System;
using System.Linq;

class LinqAny
{
    static void Main()
    {
        bool[] completes = { true, false, true };

        // 배열 또는 컬렉션의 하나의 항목이라도 조건을 만족하면 true
        Console.WriteLine(completes.Any(c => c == false));
    }
}
