// 관계형(비교) 연산자 : 
// ==
// !=
// >, <, >=, <=, ==(같은지), !=(다른지) 
using System;

public class 연산자_관계형연산자
{
    public static void Main()
    {
        int a = 10;
        int b = 5;

        Console.WriteLine(a == b);//같으냐? 다르다. false
        Console.WriteLine(a != b);//a와 b가 다르냐? 다르다 true        

        Console.WriteLine();

        int firstNum = 10;
        int secondNum = 5;
        bool r = false;

        Console.WriteLine(firstNum > secondNum); // true

        r = (firstNum <= secondNum); // false
        Console.WriteLine(r);

        r = (firstNum == secondNum); // C Family : ==, VB Family : =
        Console.WriteLine(r); // false

        r = (firstNum != secondNum); // C Family : !=, VB Family : <>
        Console.WriteLine(r); // true
    }
}
