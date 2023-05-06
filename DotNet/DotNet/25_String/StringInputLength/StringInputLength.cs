using System;

class StringInputLength
{
    static void Main()
    {
        // 문자열 변수를 선언합니다.
        string str;

        // 사용자에게 문자열을 입력받기 위한 안내 메시지를 출력합니다.
        Console.Write("문자열을 입력하세요: ");

        // 입력된 문자열을 str 변수에 저장합니다.
        str = Console.ReadLine();

        // 문자열의 길이를 계산하고 출력합니다.
        Console.WriteLine("문자열의 길이: {0}", str.Length);
    }
}
