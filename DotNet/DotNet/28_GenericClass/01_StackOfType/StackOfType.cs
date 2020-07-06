using System;
using System.Collections.Generic;

class StackOfType
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("First"); // Push() 메서드는 문자열만 입력 가능
        Console.WriteLine(stack.Pop()); // 문자열로 바로 출력
    }
}
