// LINQ Take(): 컬렉션(시퀀스)에서 지정한 수만큼의 데이터 가져오기
using System.Linq;

class LINQ_Take
{
    static void Main()
    {
        var data = Enumerable.Range(0, 100); // 0~99

        System.Console.WriteLine("앞에서 5개:");
        var five = data.Take(5);
        foreach (var f in five)
        {
            System.Console.Write("{0}\t", f);
        }
        System.Console.WriteLine("\n짝수 5개:");
        var even = data.Where(n => n % 2 == 0).Take(5);
        foreach (var e in even)
        {
            System.Console.Write("{0}\t", e);
        }
        System.Console.WriteLine();
    }
}
