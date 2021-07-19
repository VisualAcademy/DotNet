/*
스택(Stack) : LIFO(Last In First Out) 형태의 데이터를 저장
- Push() : 스택에 데이터를 저장
- Pop() : 스택에서 데이터를 출력
- Overflow : 스택이 가득찼을 때
- Underflow : 스택이 비었을 때
*/
using System;
using System.Collections;

public class 스택설명_데이터구조_스택설명_닷넷_
{
    static void Main(string[] args)
    {
        // 스택 생성
        Stack s = new Stack();
        // 스택에 데이터 저장
        s.Push("C언어");
        s.Push("C++언어");
        s.Push("C#언어");
        // 스택에서 데이터 출력
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(s.Pop());
        }
        try
        {
            s.Pop();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
