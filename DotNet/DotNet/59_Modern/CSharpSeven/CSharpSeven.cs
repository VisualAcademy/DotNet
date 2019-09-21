using System;

class SeeSharpSeven 
{
    static void Main()
    {
        //[?] C# 7.0의 새로운 특징
        // 바이너리 리터럴: 0b, 0B 접두사
        // 숫자 구분자: 1_000____________________________000
        // 튜플 리터럴: (12, 34)
        // 튜플 반환값: (int, int)
        // 튜플 이름 주기: (s:12, c:3)
        // 튜플 해체: var (sum, count) = ...
        // 패턴 매칭: if + is 연산자
        // 패턴 매칭: switch, when
    }

    static void PrintShape(object shape)
    {
        //switch (shape)
        //{
        //    case Rectangle s when (s.Length == s.Height):
        //        WriteLine($"정사각형: {s.Length} x {s.Height} ");
        //        break;
        //    case Rectangle r:
        //        WriteLine($"직사각형: {r.Length} x {r.Height} ");
        //        break;
        //    case Circle c:
        //        WriteLine($"원: 반지름({c.Radius})");
        //        break; 
        //    case null:
        //        throw new ArgumentNullException(nameof(shape)); 
        //    default:
        //        WriteLine("<기타 도형>");
        //        break;
        //}
    }
}
