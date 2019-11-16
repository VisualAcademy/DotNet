//[?] 문자열 배열을 사용하는 3가지 방법
using System;
using System.Collections.Generic;
using System.Linq;

class StringArray
{
    static void Main()
    {
        //[1] 문자열 배열을 선언하는 기본적인 방법
        var a1 = new string[] { "Red", "Green", "Blue" };

        //[2] List<T> 개체를 생성 후 문자열 배열을 ToList() 메서드로 변환
        var a2 = new List<string>(); a2 = a1.ToList();

        //[3] IEnumerable<T> 개체 생성 후 문자열 배열을 바로 대입 가능
        IEnumerable<string> a3 = a1;

        //[4] IEnumerable<T> 개체를 ToList() 메서드로 List<T> 형태로 변환
        var a4 = a3.ToList();

        //[5] IEnumerable<T> 개체는 주로 foreach 문으로 반복 사용
        foreach (var arr in a3)
        {
            Console.WriteLine(arr);
        }

        //[6] string[], List<T> 개체는 for 문으로 반복 가능
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{a1[i]}, {a2[i]}, {a4[i]}");
        }
    }
}
