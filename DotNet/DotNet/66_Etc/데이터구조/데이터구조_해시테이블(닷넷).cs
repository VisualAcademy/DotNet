// 해시테이블(Hashtable) : 배열 -> 정수형 인덱스
// a[3] = {1,2,3}; a[인덱스] : 정수형 인덱스
// aa["첫번째"] = "값";
using System;
using System.Collections;

public class 해시테이블
{
    public static void Main()
    {
        //[1] 배열
        int[] a = { 1, 2, 3 };
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(a[i]);
        }

        //[2] 해시테이블
        Hashtable h = new Hashtable();
        h[1] = "닷넷코리아";
        h["두번째"] = "제일스터디";
        h[11.22] = "하와소";

        Console.WriteLine(h[1]);
        Console.WriteLine(h["두번째"]);
        Console.WriteLine(h[11.22]);
    }
}