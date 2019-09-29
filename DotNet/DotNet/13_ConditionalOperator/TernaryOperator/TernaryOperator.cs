using System;

class TernaryOperator
{
    static void Main()
    {
        string result = "";

        // 'A'는 'B'보다 작으므로 참이므로 앞에 문자열이 result 변수에 저장
        result = ('A' < 'B') ? "'A'는 'B'보다 작습니다." : "A B C 순서로 커집니다.";
        Console.WriteLine(result);

        // 'Z'는 'a'보다 작으므로 참이므로 앞에 문자열이 result 변수에 저장
        result = 
            ('Z' < 'a') ? "'Z'는 'a'보다 작습니다." : "대문자보다 소문자가 더 큽니다.";
        Console.WriteLine(result);
    }
}
