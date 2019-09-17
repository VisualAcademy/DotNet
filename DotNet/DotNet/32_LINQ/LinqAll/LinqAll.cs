// All() 확장 메서드: 시퀀스의 모든 요소가 조건을 만족 하는지 여부
using System;
using System.Linq;

class LinqAll
{
    static void Main()
    {
        bool[] completes = { true, true, true };

        // 배열 또는 컬렉션의 모든 항목이 true일때에만 true을 반환
        Console.WriteLine(completes.All(c => c == true));
    }
}
