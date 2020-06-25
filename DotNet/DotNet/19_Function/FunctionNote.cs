using System; 

class FunctionNote
{
    // 선언
    static int Sum(int first, int second = 5) => (first + second);

    // 호출: DotNet.exe 3 5 
    static void Main(string[] args)
    {
        int first = Convert.ToInt32(args[0]);
        int second = Convert.ToInt32(args[1]);
        Console.WriteLine(Sum(first, second));    
    } 
}
