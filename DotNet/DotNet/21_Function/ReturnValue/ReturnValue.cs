// 반환값이 있는 함수 만들고 호출하기 
using System;

class ReturnValue
{
    static string GetString()
    {
        return "반환값(Return Value)"; // return 키워드로 단순 문자열 반환
    }

    static void Main()
    {
        // GetString() 함수 호출 후 반환된 반환값을 returnValue 변수에 저장
        string returnValue = GetString();
        Console.WriteLine(returnValue);
    }
}
