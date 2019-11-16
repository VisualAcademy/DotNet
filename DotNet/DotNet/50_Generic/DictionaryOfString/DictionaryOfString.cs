using System;
using System.Collections.Generic;

public class DictionaryOfString
{
    static void Main()
    {
        //[1] Dictionary<T> 클래스: 키(Key)와 값(Value)의 쌍으로 컬렉션을 관리
        Dictionary<string, string> nickNames = new Dictionary<string, string>();
        nickNames.Add("Taeyo", "태오");
        nickNames.Add("RedPlus", "레드플러스");
        nickNames.Add("Itist", "아이티스트");

        //[2] ContainsKey() 메서드로 키 확인
        if (nickNames.ContainsKey("RedPlus"))
        {
            Console.WriteLine(nickNames["RedPlus"]);
        }
    }
}
