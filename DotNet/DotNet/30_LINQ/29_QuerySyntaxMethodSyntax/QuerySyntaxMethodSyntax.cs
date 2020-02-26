using System.Linq;
using static System.Console;

class QuerySyntaxMethodSyntax
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        WriteLine((from n in numbers where n % 2 == 0 select n).Sum());
        WriteLine((from n in numbers where n % 2 == 0 select n).Count());
        WriteLine((from n in numbers where n % 2 == 0 select n).Average());
        WriteLine((from n in numbers where n % 2 == 0 select n).Max());
        WriteLine((from n in numbers where n % 2 == 0 select n).Min());
    }
}
