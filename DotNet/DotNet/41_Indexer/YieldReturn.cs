//[?] yield return을 사용하여 이터레이터 구현하기
using System;
using System.Collections;

class YieldReturn
{
    //[1] 반복기(이터레이터) 구현: MultiData() 메서드는 3번 반복해서 문자열이 반환됨
    static IEnumerable MultiData()
    {
        yield return "Hello";
        yield return "World";
        yield return "C#";
    }

    static void Main()
    {
        //[2] 반복기를 foreach 문으로 호출해서 사용 
        foreach (var item in MultiData())
        {
            Console.WriteLine(item);
        }
    }
}
