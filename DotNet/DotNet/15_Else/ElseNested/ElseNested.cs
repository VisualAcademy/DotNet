// 하나의 입력된 문자에 따라서 'y'이면 "Yes"를, 'n'이면 "No"를, 
// 나머지는 모두 "Cancel"을 출력하는 프로그램
using System;

class ElseNested
{
    static void Main()
    {
        Console.Write("문자를 입력하세요. (y/n/c): ");
        char input = Convert.ToChar(Console.ReadLine());
        if (input == 'y')
        {
            Console.WriteLine("Yes");
        }
        else
        {
            if (input == 'n')
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Cancel");
            }
        }
    }
}
