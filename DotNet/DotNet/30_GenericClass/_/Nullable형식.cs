// nullable 형식 : null(값이 없음을 의미)이 할당될 수 있는 형식
// 널가능형식, 널가능자
using System;

public class Nullable형식
{
    public static void Main()
    {
        // 참조 형식 : null 할당 가능
        string s = null; Console.WriteLine(s); 

        // 값 형식 : null 할당 불가능 -> 에러
        // int i = null; Console.WriteLine( i );

        // Nullable 형식 : null 할당할 수 있는 형식
        int? i = null; Console.WriteLine(i);
        double? d = null; Console.WriteLine(d);

        // System.Nullable<T> 제네릭 클래스
        Nullable<int> ii = null; Console.WriteLine(ii);
        Nullable<double> dd = null; Console.WriteLine(dd);
    }
}
