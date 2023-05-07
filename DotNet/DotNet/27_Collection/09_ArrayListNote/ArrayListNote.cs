using System;
using System.Collections;

class ArrayListNote
{
    static void Main()
    {
        // ArrayList 객체를 생성합니다.
        ArrayList list = new ArrayList();

        // "C#" 문자열을 ArrayList에 추가합니다.
        list.Add("C#");

        // "TypeScript" 문자열을 ArrayList에 추가합니다.
        list.Add("TypeScript");

        // ArrayList의 요소를 순회하면서 출력합니다.
        for (int i = 0; i < list.Count; i++)
        {
            // ArrayList의 i번째 요소를 문자열로 변환하여 출력합니다.
            Console.WriteLine(list[i].ToString());
        }
    }
}
