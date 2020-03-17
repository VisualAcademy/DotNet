using System;

class OutVariableDemo
{
    static void Main()
    {
        // xmax 변수를 외부에서 선언할 필요없이 TryParse() 구문에 포함해서 사용
        if (DateTime.TryParse("2020/12/25", out var xmas))
        {
            Console.WriteLine(xmas);
        }

        // "out var 변수" 구문은 실제로는 "out 데이터형식 변수" 형태로 새로운 변수를 생성
        if (!DateTime.TryParse("20200707", out DateTime doubleSeven))
        {
            doubleSeven = DateTime.Now; // 만약, 변경이 불가능하다면 현재 시간으로 초기화
        }
        Console.WriteLine(doubleSeven); // if 문과 같은 범위에 변수가 생성됨
    }
}
