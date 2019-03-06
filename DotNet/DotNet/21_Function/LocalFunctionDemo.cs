using System;

class LocalFunctionDemo
{
    static void Main()
    {
        Display("로컬 함수");

        // 로컬 함수: 메서드(함수)내에서만 사용되는 또 다른 함수
        void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
