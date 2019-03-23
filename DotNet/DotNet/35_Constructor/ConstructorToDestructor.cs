using static System.Console;

public class Test
{
    // 생성자
    public Test()
    {
        WriteLine("[1] 생성");
    }
    // 메서드
    public void Run()
    {
        WriteLine("[2] 실행");
    }
    // 소멸자: GC
    ~Test()
    {
        WriteLine("[3] 소멸");
    }
}

class ConstructorToDestructor
{
    static void Main()
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        Test test = new Test();
        test.Run();
        // System.GC.Collect(); 
    }
}
