using System;

class ConstructorLog
{
    public ConstructorLog()
    {
        Console.WriteLine("기본 생성자 실행");
    }

    public ConstructorLog(string message)
    {
        Console.WriteLine("오버로드된 생성자 실행 : " + message);
    }
}

class ConstructorOverload
{
    static void Main()
    {
        ConstructorLog log1 = new ConstructorLog();
        ConstructorLog log2 = new ConstructorLog("C#");
        ConstructorLog log3 = new ConstructorLog("ASP.NET");
    }
}
