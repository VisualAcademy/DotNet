using System;

class ThousandsSeparator
{
    static void Main()
    {
        // 사용자로부터 숫자를 입력 받음
        Console.Write("변환시킬 숫자를 입력하세요... => ");
        string input = Console.ReadLine();

        // 입력 받은 문자열이 유효한 숫자인지 검사
        if (!IsValidNumber(input))
        {
            Console.WriteLine("유효한 숫자가 아닙니다.");
            return;
        }

        // 천 단위마다 콤마를 추가하여 결과 문자열 생성
        string result = AddCommas(input);
        // 결과 문자열 출력
        Console.WriteLine($"변환 결과 : {result}");
    }

    // 문자열이 숫자로만 구성되어 있는지 검사하는 함수
    static bool IsValidNumber(string str)
    {
        foreach (char ch in str)
        {
            if (ch < '0' || ch > '9')
            {
                return false; // 숫자가 아닌 문자가 있을 경우 false 반환
            }
        }
        return true; // 모든 문자가 숫자일 경우 true 반환
    }

    // 천 단위마다 콤마를 추가하는 함수
    static string AddCommas(string str)
    {
        int length = str.Length;
        int count = 0;
        string result = string.Empty;

        // 문자열을 역순으로 처리하며 천 단위마다 콤마를 추가
        for (int i = length - 1; i >= 0; i--)
        {
            result = str[i] + result;
            count++;

            if (count % 3 == 0 && i > 0)
            {
                result = "," + result; // 콤마 추가
            }
        }

        return result;
    }
}
