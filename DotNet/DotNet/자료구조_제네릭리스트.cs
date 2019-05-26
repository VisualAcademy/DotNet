using System;
using System.Collections;
using System.Collections.Generic;

public class 자료구조_제네릭리스트
{
    public static void Main(string[] args)
    {
        // 기본 ArrayList
        //System.Collections.ArrayList arr = new System.Collections.ArrayList();
        ArrayList arr = new ArrayList();

        arr.Add(10); //정수형데이터를입력받는데object형매개변수로받음 
        arr.Add(20);

        // 제네릭 List 클래스
        //System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
        List<int> list = new List<int>();

        list.Add(10); // 매개변수 형식이 <int>에 의해 int형으로 변경
        list.Add(20);

        // 문자열 여러개 담을 수 있는 리스트 제공
        List<string> items = new List<string>();
        items.Add("데브렉");
        items.Add("레드플러스");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine("{0}", items[i]);
        }
    }
}
