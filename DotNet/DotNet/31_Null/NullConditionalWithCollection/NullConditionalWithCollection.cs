// ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
// ?. 연산자는 엘비스의 머리 모양과 비슷하다고 하여 Elvis 연산자라고도 함
using System;
using System.Collections.Generic;

class NullConditionalWithCollection
{
    static void Main()
    {
        List<string> list = null;
        int? numberOfList;

        //[1] 리스트가 null이면 null 반환
        numberOfList = list?.Count; // null
        if (numberOfList == null)
        {
            Console.WriteLine($"[1] 리스트 카운트: null");
        }

        list = new List<string>();
        list.Add("안녕하세요."); list.Add("반갑습니다.");

        //[2] 리스트가 null이 아니므로 Count 속성의 값인 2 반환
        numberOfList = list?.Count; // 2
        if (numberOfList != null)
        {
            Console.WriteLine($"[2] 리스트 카운트: {numberOfList}");
        }
    }
}
