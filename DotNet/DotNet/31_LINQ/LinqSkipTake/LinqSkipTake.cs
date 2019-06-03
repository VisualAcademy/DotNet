// LINQ Skip(): 컬렉션(시퀀스)에서 지정한 수만큼의 데이터 제외하기 
using System.Linq;
using static System.Console;

class LinqSkipTake
{
    static void Main()
    {
        var data = Enumerable.Range(0, 100); // 0~99

        var next = data.Skip(10).Take(5); // 10개 제외하고 5개 가져오기

        foreach (var n in next)
        {
            WriteLine(n);
        }
    }
}
