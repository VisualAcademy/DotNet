//[?] Hashtable 클래스를 사용하여 정수 형식 또는 문자열 형식 인덱스 사용하여 값 저장하기
using System;
using System.Collections;

class HashtableDemo
{
    static void Main()
    {
        //[1] Hashtable의 인스턴스 생성
        Hashtable hash = new Hashtable();

        //[2] 배열형 인덱서를 사용 가능한 구조 및 문자열 인덱스 사용 가능
        hash[0] = "닷넷코리아"; //[A] 배열과 같은 n번째 형태 사용 가능
        hash["닉네임"] = "레드플러스"; //[B] 문자열 인덱스 사용 가능
        hash["사이트"] = "비주얼아카데미";

        //[3] 직접 출력
        Console.WriteLine(hash[0]);
        Console.WriteLine(hash["닉네임"]);
        Console.WriteLine(hash["사이트"]);

        //[4] key와 value 쌍으로 출력 가능
        foreach (object o in hash.Keys)
        {
            Console.WriteLine(hash[o]);
        }
    }
}
