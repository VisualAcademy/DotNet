using System;

class LogicalOperatorPractice
{
    static void Main()
    {
        bool bln1 = true;
        bool bln2 = false;

        Console.WriteLine("[1] {0}", bln1 && bln1); //[1] True
        Console.WriteLine("[2] {0}", bln1 || bln2); //[2] True 
    }
}
