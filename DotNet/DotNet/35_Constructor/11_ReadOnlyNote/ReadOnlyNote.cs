//[?] 생성자를 사용하여 읽기 전용 필드 초기화
using System;

public class WhitchService
{
    // 읽기 전용 필드
    private readonly string _serviceName;

    public WhitchService(string serviceName)
    {
        // 읽기 전용 필드는 생성자에 의해서 초기화해서 사용 가능
        _serviceName = serviceName;
    }

    public void Run() => Console.WriteLine($"{_serviceName} 기능을 실행합니다.");
}

class ReadOnlyNote
{
    static void Main()
    {
        var file = new WhitchService("[1] 파일 로그");
        file.Run();

        var db = new WhitchService("[2] DB 로그");
        db.Run();
    }
}
