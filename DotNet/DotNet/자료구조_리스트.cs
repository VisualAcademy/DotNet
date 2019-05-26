// ArrayList : Stack + Queue : (배열에 비해서)데이터 삽입과 삭제가 쉽다. 다만, 속도는 배열이 빠르다.
// Add() : 입력
// Remove() : 삭제
// 인덱서로 출력
using System;
using System.Collections;

public class 자료구조_리스트
{
    public static void Main(string[] args)
    {
        //[1] ArrayList 클래스의 인스턴스 생성
        ArrayList list = new ArrayList();

        //[2] 데이터 입력
        list.Add("데브렉");
        list.Add("닷넷코리아");
        list.Add("비주얼아카데미");

        //[3] 데이터 삭제
        list.Remove("닷넷코리아"); // 직접 삭제 및 인덱스로 삭제 가능

        //[4] 데이터 출력
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]); // 인덱서로 출력
        }

        //[!] 기타 많은 메서드들 제공
        //list.RemoveAt(0);

        //[5] 리스트 클리어 : 모두 삭제
        list.Clear();
    }
}
