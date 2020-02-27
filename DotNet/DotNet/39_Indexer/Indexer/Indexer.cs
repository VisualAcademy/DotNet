//[?] 인덱서를 사용하여 여러 값을 주고 받기
using System;

namespace Indexer
{
    class Developer
    {
        private string name;
        // 인덱서 
        public string this[int index]
        {
            get { return name; }    // [index]로 요청시 특정 필드의 값을 반환한다.
            set { name = value; }   // 넘어온 값은 value 키워드로 읽어올 수 있다.
        }
    }

    class Indexer
    {
        static void Main()
        {
            var developers = new Developer();
            developers[0] = "홍길동"; // 인덱스와 상관없이 name 필드에 문자열이 저장된다. 
            Console.WriteLine(developers[0]); // 홍길동
            developers[1] = "백두산";
            Console.WriteLine(developers[1]); // 백두산
        }
    }
}
