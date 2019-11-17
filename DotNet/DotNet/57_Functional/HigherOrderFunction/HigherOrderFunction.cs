//[?] 고차 함수(Higher-Order Function): 함수 자체를 매개 변수 또는 반환값으로 가지는 함수
using System;

class HigherOrderFunction
{
    //[1] 매개 변수가 Action<T>
    static void FunctionParameterWithAction(Action<string> action, string message)
    {
        action(message);
    }

    //[2] 매개 변수가 Func<T>
    static void FunctionParameterWithFunc(Func<int, int> func, int number)
    {
        int result = func(number);
        Console.WriteLine($"{number} * {number} = {result}");
    }

    //[3] 반환값이 Action<T>
    static Action<string> FunctionReturnValueWithAction() =>
        msg => Console.WriteLine($"{msg}");

    //[4] 반환값이 Func<T>
    static Func<int, int> FunctionReturnValueWithFunc() => x => x * x;

    static void Main()
    {
        //[A] Action<T> 매개 변수 전달: 문자열을 받아 출력하는 함수 정의
        Action<string> action = message => Console.WriteLine(message);
        FunctionParameterWithAction(action, "고차 함수: 매개 변수");

        //[B] Func<T> 매개 변수 전달: 정수 값을 받아 두 번 곱한 후 다시 정수 값 반환
        Func<int, int> func = x => x * x;
        FunctionParameterWithFunc(func, 3);

        //[C] Action<T> 반환값 
        FunctionReturnValueWithAction()("고차 함수: 반환값");

        //[D] Func<T> 반환값
        int number = 3;
        int result = FunctionReturnValueWithFunc()(number);
        Console.WriteLine($"{number} * {number} = {result}"); // 9 
    }
}
