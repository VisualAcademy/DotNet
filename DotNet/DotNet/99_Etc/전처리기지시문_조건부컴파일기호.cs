// #define HELLO 
using System;

namespace 전처리기지시문_조건부컴파일기호
{
    class 전처리기지시문_조건부컴파일기호
    {
        static void Main(string[] args)
        {
            // 메일을 보내는 로직
#if DEBUG
            Console.WriteLine("테스트 환경: 가짜로 메일을 보냅니다.");
#else
            Console.WriteLine("운영 환경: 진짜로 메일을 보냅니다.");
#endif

            // 특정 기호 정의 확인
#if HELLO
            Console.WriteLine("조건부 컴파일 기호 중 HELLO가 정의되어 있습니다.");
#else   
            Console.WriteLine("조건부 컴파일 기호 중 HELLO가 정의되지 않았습니다.");
#endif
        }
    }
}
