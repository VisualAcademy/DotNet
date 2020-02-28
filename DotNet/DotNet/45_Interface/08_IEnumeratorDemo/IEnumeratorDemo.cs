//[?] IEnumerator 인터페이스 사용해보기
using System;
using System.Collections;

class IEnumeratorDemo
{
    static void Main()
    {
        string[] names = { "닷넷코리아", "비주얼아카데미" };

        //[1] foreach 문으로 출력
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //[2] IEnumerator 인터페이스를 통한 데이터 출력: foreach문과 동일
        IEnumerator list = names.GetEnumerator(); // 하나씩 열거
        while (list.MoveNext()) // 값이 있는 동안 반복
        {
            Console.WriteLine(list.Current); // 현재 반복중인 데이터 출력
        }
    }
}
