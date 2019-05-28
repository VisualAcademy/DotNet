using System;

class LogicalOperatorExam
{
    static void Main(string[] args)
    {
        bool bln1 = true;
        bool bln2 = false;

        Console.WriteLine("[1] {0}", bln1 && bln1);     //[1] True
        Console.WriteLine("[2] {0}", !bln2);            //[2] True 
    }
}
