using System;
using System.Collections;

namespace 인덱서확장
{
    public class NickName
    {
        // 해시테이블형 필드 생성
        public Hashtable names = new Hashtable();
        // 정수형 인덱서 구현
        public string this[int index]
        {
            get { return (string)names[index]; }
            set { names[index] = value; }
        }
        // 문자열 인덱서 구현 : key/value
        public string this[string key]
        {
            get { return (string)names[key]; }
            set { names[key] = value; }
        }
        // 반복기(참고)
        public IEnumerator GetEnumerator()
        {
            foreach (object o in names.Keys)
            {
                yield return names[o];
            }
        }
    }
    public class 인덱서확장
    {
        public static void Main(string[] args)
        {
            // NickName 클래스의 인스턴스 생성
            NickName nick = new NickName();
            // 정수형 인덱서 사용 : index/value
            nick[0] = "닷넷코리아";
            // 문자열 인덱서 사용 : key/value 쌍
            nick["박용준"] = "레드플러스";
            nick["하와소"] =
              "http://www.hawaso.com";
            // 출력
            Console.WriteLine(
              "{0}, {1}, {2}"
              , nick[0]
              , nick["박용준"]
              , nick["하와소"]);
            // foreach문으로 출력
            foreach (object o in nick)
            {
                Console.WriteLine(o);
            }
        }
    }
}
