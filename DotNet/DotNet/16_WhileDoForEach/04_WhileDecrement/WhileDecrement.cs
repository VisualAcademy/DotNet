// 초깃값을 감소시켜서 반복시키기   
using System;

class WhileDecrement
{
    static void Main()
    {
        int index = 5;
        while (index > 0)
        {
            Console.WriteLine($"안녕하세요. {index}");
            index--;
        }
    }
}
