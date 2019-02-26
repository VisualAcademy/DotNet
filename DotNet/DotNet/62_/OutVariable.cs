using System;

class OutVariable
{
    static void Main()
    {
        // [1] C# 6.0까지의 사용 방법: 변수를 미리 선언
        int r;
        if (int.TryParse("안녕", out r))
        {
            // "안녕"은 int 형으로 변환이 불가능하기에 이 코드는 실행되지 않음
            Console.WriteLine("{0}", r); 
        }

        // [2] C# 7.0 이후로의 out var 방식
        if (int.TryParse("1234", out var result))
        {
            // "1234"는 int 형식으로 변환이 가능하기에 result 선언과 동시에 1234가 저장됨
            Console.WriteLine(result); // 1234
        }
        Console.WriteLine(result); // 1234 : if문에서 밖에서도 사용 가능
    }
}
