// ����� �μ�(���ø����̼� �μ�)
using System; 

public class CommandLineDemo
{
    // Command Line Argument
    public static void Main(string[] args)
    {
        int first = int.Parse(args[0]);             // 1
        int second = Convert.ToInt32(args[1]);      // 2
        System.Console.WriteLine(first + second);   // 1 + 2 = 3
    }
}
