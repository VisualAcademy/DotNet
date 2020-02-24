using System;

namespace 배열
{
    class 배열
    {
        static void Main(string[] args)
        {
            //[1] arr 이름으로 정수형 배열 선언 및 요소 수 
            int[] arr = new int[2];

            //[2] 배열 초기화(할당)
            arr[0] = 100;
            arr[1] = 200;

            //[3] 배열 참조(사용)
            Console.WriteLine(arr[0]); // 100
            Console.WriteLine(arr[1]); // 200

            //[1] 문자열형 배열 선언 및 초기화
            string[] msgs = new string[2];
            msgs[0] = "안녕하세요.";
            msgs[1] = "반갑습니다.";
            
            //[2] 반복문을 사용하여 배열 탐색
            for (int i = 0; i < msgs.Length; i++)
            {
                Console.WriteLine(msgs[i]);
            }
        }
    }
}
