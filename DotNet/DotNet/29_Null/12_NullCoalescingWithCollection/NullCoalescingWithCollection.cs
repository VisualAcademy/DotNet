// 널 병합 연산자와 널 조건부 연산자 함께 사용하기 
// ?? 연산자: 컬렉션이 null이 아니면 해당 값 반환, null이면 뒤에 지정한 값 반환
// ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
using System;
using System.Collections.Generic;

class NullCoalescingWithCollection
{
    static void Main()
    {
        int num;
        List<string> list;

        //[1] 컬렉션 리스트가 null이면 Count를 읽을 수 없기에 0으로 초기화
        list = null; 
        num = list?.Count ?? 0; // null이면 0 반환, 오른쪽 값 사용
        Console.WriteLine($"[1] 컬렉션 카운트: {num}"); // 0

        //[2] 컬렉션 리스트가 null이 아니면 Count 속성의 값을 사용 
        list = new List<string>(); list.Add("또 만나요.");
        num = list?.Count ?? 0; // null이 아니기 때문에 왼쪽 값 사용
        Console.WriteLine($"[2] 컬렉션 카운트: {num}"); // 1
    }
}
