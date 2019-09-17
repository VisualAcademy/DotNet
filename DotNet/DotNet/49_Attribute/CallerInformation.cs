using System.Runtime.CompilerServices;
using static System.Console;

class CallerInformation
{
    static void Main()
    {
        TraceMessage("여기서 무엇인가 실행...");
    }

    public static void TraceMessage(string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
    {
        WriteLine("실행 내용: " + message);
        WriteLine("멤버 이름: " + memberName);
        WriteLine("소스 경로: " + sourceFilePath);
        WriteLine("실행 라인: " + sourceLineNumber);
    }
}
