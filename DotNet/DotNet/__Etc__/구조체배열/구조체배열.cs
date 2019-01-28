using System;

namespace 구조체
{
    public struct BizCard
    {
        /// <summary>
        /// 이름을 입력하시오.
        /// </summary>
        public string Name;      // 이름
        public int Age;          // 나이
        public string Address;   // 주소
    }
    public class 구조체배열
    {
        static void Main(string[] args)
        {
            // 구조체 형 배열 선언
            BizCard[] biz = new BizCard[2];
            // 따로 초기화
            biz[0].Name = "홍길동";
            biz[0].Age = 21;
            biz[0].Address = "서울";
            biz[1].Name = "백두산";
            biz[1].Age = 102;
            biz[1].Address = "부산";
            // 출력
            for (int i = 0; i < biz.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}"
                    , biz[i].Name, biz[i].Age, biz[i].Address);
            }
        }
    }
}
