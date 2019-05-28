using System;

class NullableOf
{
    static void Main()
    {
        // Nullable<T> 구조체를 사용하여 널 가능 형식 변수 만들기
        Nullable<bool> bln = null;

        if (bln.HasValue == true)
        {
            Console.WriteLine($"bln 변수의 값은 {bln.Value}입니다.");
        }
        else
        {
            Console.WriteLine("bln 변수의 값은 null입니다.");
        }
    }
}
