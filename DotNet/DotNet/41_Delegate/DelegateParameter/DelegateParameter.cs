using System;

class DelegateParameter
{
    //[?] 대리자(델리게이트)는 동일한 메서드 시그니처를 갖는 메서드의 참조를 담을 수 있는 그릇
    delegate void Runner();

    static void Main()
    {
        RunnerCall(new Runner(Go));     // "직진"
        RunnerCall(new Runner(Back));   // "후진"
    }

    static void RunnerCall(Runner runner) => runner(); // 넘어온 메서드(함수) 실행        
    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");
}
