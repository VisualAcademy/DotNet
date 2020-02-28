using System;
using System.Collections;

class StackClass
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push("First");
        stack.Push("Second");

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        // Console.WriteLine(stack.Pop());
    }
}
