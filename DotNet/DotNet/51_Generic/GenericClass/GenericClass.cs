//[?] 제네릭 클래스: T에 지정한 형식으로 클래스와 멤버의 성질이 결정
using System;

namespace GenericClass
{
    //[1] 클래스<T> 형태로 제네릭 클래스 만들기 
    public class Cup<T>
    {
        public T Content { get; set; }
    }

    class GenericClass
    {
        static void Main()
        {
            //[A] T에 string 전달하여 문자열 저장하는 속성 생성
            Cup<string> text = new Cup<string>();
            text.Content = "문자열"; // string

            //[B] T에 int 전달하여 정수형 저장하는 속성 생성 
            Cup<int> number = new Cup<int>();
            number.Content = 1234; // int

            Console.WriteLine($"{text.Content}, {number.Content}");
        }
    }
}
