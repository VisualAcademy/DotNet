using System;
using System.Collections.Generic;

namespace DictionaryGenericClassDemo
{
    class DictionaryGenericClassDemo
    {
        static void Main(string[] args)
        {
            // Dictionary 클래스의 인스턴스 생성
            IDictionary<string, string> data = new Dictionary<string, string>();
            // 데이터 입력
            data.Add("cs", "C#");
            data.Add("aspx", "ASP.NET");
            data.Add("vb", "Visual Basic");
            // 데이터 삭제
            data.Remove("aspx");
            // 인덱서를 사용해서 데이터 입력
            data["cshtml"] = "ASP.NET MVC";
            // 키값 중복 불가
            try
            {
                data.Add("cs", "CSharp");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            // 출력
            //foreach (var item in data)
            foreach (KeyValuePair<string, string> item in data)
            {
                Console.WriteLine("{0}은(는) {1}의 확장자입니다.", item.Key, item.Value);
            }
            // 인덱서를 사용해서 출력
            Console.WriteLine(data["vb"]);
            // 없는 키 출력
            try
            {
                Console.WriteLine(data["vbhtml"]);
            }
            catch (KeyNotFoundException knfe)
            {
                Console.WriteLine(knfe.Message);
            }
            string value = "";
            if (data.TryGetValue("vbhtml", out value))
            {
                Console.WriteLine(data["vbhtml"]);
            }
            else
            {
                Console.WriteLine("vbhtml 키가 없습니다.");
            }
            // 키값이 없으면 입력하고 출력
            if (!data.ContainsKey("vbhtml"))
            {
                data.Add("vbhtml", "ASP.NET MVC(VB)");
                Console.WriteLine(data["vbhtml"]);
            }
            // Value 들만 따로 뽑아서 출력
            var values = data.Values;
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }
            // Key 들만 따로 뽑아서 출력
            var keys = data.Keys;
            foreach (string item in keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
