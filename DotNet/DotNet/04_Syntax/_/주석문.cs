// 주석문(Comment): 코드 설명문
// 주석문 종류: //(한 줄 주석), /* ~ */(여러 줄 주석), ///(XML 문서 주석)
// 전처리기 지시문: #region ~ #endregion

/// <summary>
/// 주석문 학습을 위한 예제
/// 작성자: 홍길동
/// </summary>
class 주석문
{
    /// <summary>
    /// Main 메서드는 C# 프로그램의 진입점(Entry Point)
    /// </summary>
    /// <param name="args">명령줄 인수</param>
    static void Main(string[] args)
    {
        #region *전처리기 지시문 영역*
        System.Console.WriteLine("// : 한 줄 주석");
        System.Console.WriteLine("/* */ : 여러 줄 주석");
        System.Console.WriteLine("/// : XML 문서 주석");
        System.Console.WriteLine("#region #endregion : 전처리기 지시문");
        #endregion
    }
}

/*
 
여러 줄 주석

- 주석문은 적절히 사용하기를 권장

*/