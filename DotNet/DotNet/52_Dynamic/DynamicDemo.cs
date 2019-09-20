//[?] dynamic 키워드: 런타임에 데이터 형식이 결정되는 변수를 생성
using System;

class DynamicDemo
{
    static void Main()
    {
        string ss = "안녕하세요."; //[1] 코드 작성시 문자열로 판단
        Console.WriteLine(ss.Length); // 인텔리센스의 도움 받음

        var vs = "반갑습니다."; //[2] 컴파일시 문자열로 판단
        Console.WriteLine(vs.Length); // 인텔리센스의 도움 받음

        dynamic ds = "또 만나요."; //[3] 런타임시 문자열로 판단
        Console.WriteLine(ds.Length); // 인텔리센스의 도움 못 받음

        ds = 1234; // [4]런타임시 숫자형으로 판단
        Console.WriteLine(ds * 10); // 숫자형 연산이 가능: 12340
    }
}
