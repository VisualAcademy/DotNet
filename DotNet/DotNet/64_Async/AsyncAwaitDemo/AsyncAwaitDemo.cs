using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class AsyncAwaitDemo
    {
        static void Main(string[] args)
        {
            //[1] 동기
            //동기메서드테스트();
            //[2] 비동기
            비동기메서드테스트();

            Console.WriteLine("[?] 아무키나 누르면 프로그램을 종료합니다.");
            Console.ReadLine(); // 입력 대기
        }

        private async static void 비동기메서드테스트()
        {
            await 오래걸리메서드Async();
        }

        public static async Task<int> 오래걸리메서드Async()
        {
            Console.WriteLine("[1] 오래 걸리는 메서드 시작");
            await Task.Delay(5000); // 5초 딜레이: 비동기 환경에서만 작동
            Console.WriteLine("[2] 오래 걸리는 메서드 종료");
            return 1;
        }

        private static void 동기메서드테스트()
        {
            Console.WriteLine("[1] 오래 걸리는 메서드 시작");
            Thread.Sleep(5000); // 5초 딜레이: 동기 환경에서만 사용할 것
            Console.WriteLine("[2] 오래 걸리는 메서드 종료");
        }
    }
}
