//[?] 문자열을 거꾸로 변환하는 프로그램
using System;

class StringReverse
{
    static void Main()
    {
        Console.Write("입력: ");
        string source = Console.ReadLine();

        //[1] 기본 API를 사용하여 문자열 역순 출력 
        var target1 = source.ToCharArray();
        Array.Reverse(target1);
        Console.WriteLine($"출력: {new string(target1)}");

        //[2] 코드를 직접 작성하여 문자열 역순 출력 
        int i, j;
        char temp;
        var target2 = source.ToCharArray();

        //[!] 처음 문자와 마지막 문자를 계속해서 교환하고 증감
        for (i = 0, j = target2.Length - 1; i < j; i++, j--)
        {
            // 교환(SWAP)
            temp = target2[i]; 
            target2[i] = target2[j]; 
            target2[j] = temp;
        }

        Console.WriteLine($"출력: {new string(target2)}");
    }
}
