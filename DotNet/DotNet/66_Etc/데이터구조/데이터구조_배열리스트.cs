using System;
using System.Collections;//ArrayList, SortedList, Stack, Queue

public class 데이터구조_배열리스트
{
    public static void Main()
    {
        //[1] ArrayList의 인스턴스 생성
        ArrayList alMyFriend = new ArrayList();

        //[2] ArrayList에 데이터 추가
        alMyFriend.Add("홍길동");
        alMyFriend.Add("백두산");
        alMyFriend.Add("천두산");

        //[3] ArrayList에서 원하는 인덱스 데이터 삭제
        alMyFriend.RemoveAt(1);//백두산 왕따

        //[4] ArrayList에서 데이터 추출
        Console.Write("{0}\n", alMyFriend[1]);
    }
}
