// 함수의 매개 변수 이름을 지정하여 호출하기 
using System;

class NamedParameter
{
    static void Main()
    {
        // 기본 형태
        Sum(10, 20); // 30

        // [1] 매개 변수 이름과 콜론(:) 기호를 사용하여 호출
        Sum(first: 10, second: 20); // 30

        // [2] 매개 변수 이름 지정하면 변수 위치 변경 가능
        Sum(second: 20, first: 10); // 30
    }

    // 명명된 매개 변수(Named Parameter)
    static void Sum(int first, int second)
    {
        Console.WriteLine(first + second);
    }
}
