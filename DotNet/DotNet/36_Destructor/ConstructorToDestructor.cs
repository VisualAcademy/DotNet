using static System.Console;

public class DestructorTest
{
    // 생성자
    public DestructorTest()
    {
        WriteLine("[1] 생성");
    }
    // 메서드
    public void Run()
    {
        WriteLine("[2] 실행");
    }
    // 소멸자: GC
    ~DestructorTest()
    {
        WriteLine("[3] 소멸");
    }
}

class ConstructorToDestructor
{
    static void Main()
    {
        DestructorTest test = new DestructorTest(); // 생성
        test.Run(); // 실행
        // GC.Collect(); // 소멸
    }
}
