using System;

class NameOfOperator
{
    static void Main()
    {
        Console.WriteLine("NameToString");          // "NameToString"
        Console.WriteLine(nameof(NameToString));    // "NameToString"
    }

    static void NameToString()
    {
        // 프로그래밍할 때 함수명 또는 속성명을 다른 곳에 문자열로 넘겨주어야할 때가 있다. 
    }
}
