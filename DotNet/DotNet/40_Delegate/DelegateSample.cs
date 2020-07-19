//[?] 대리자(Delegate): 대신, 위임, 함수 포인터, 메서드 대신 호출, 대리 운전, 메서드의 매개 변수로 전달
using System;

class DelegateSample
{
    static void GoForward() => Console.WriteLine("직진");
    static void GoLeft() => Console.WriteLine("좌회전");
    static void GoFast() => Console.WriteLine("과속");
    //static void GoRight() => Console.WriteLine("우회전");
    delegate void CarDriver(); // 대리자 형식 생성
    static void Main()
    {
        //GoForward(); //[1] 내가 직접 운전
        //CarDriver goHome = new CarDriver(GoForward); //[2] 대리 운전
        CarDriver goHome = GoForward;
        goHome += GoLeft; goHome += GoFast; goHome -= GoFast;
        goHome += delegate () { Console.WriteLine("우회전"); }; //[3] 무명 메서드/익명 함수
        //goHome += delegate { Console.WriteLine("후진"); };
        goHome += () => Console.WriteLine("후진"); //[4] 람다 식
        goHome(); // goHome.Invoke();

        // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성: Func<T>, Action<T>, Predicate<T>, ...
        Action driver = GoForward;
        driver += GoLeft;
        driver += delegate () { Console.WriteLine("우회전"); };
        driver += () => Console.WriteLine("후진");
        driver(); // 트리거(방아쇠)

        Action go = () => Console.WriteLine("운전");
        go();

        RunLambda(() => Console.WriteLine("매개 변수로 람다 식(함수 이름, 무명 메서드) 전달"));
    }
    static void RunLambda(Action action) => action();
}
