using static System.Console; // System.Console까지 생략 가능

class LogicalOperator
{
    static void Main()
    {
        var i = 3;
        var j = 5;
        var r = false;

        r = (i == 3) && (j != 3); // r = true && true => true
        WriteLine(r); // true

        r = (i != 3) || (j == 3); // r = false || false => false
        WriteLine(r); // false

        r = (i >= 5); // r => false
        WriteLine("{0}", !r); // false <-> true

        WriteLine(false && true); // false
        WriteLine((1 == 1) || (1 != 1)); // true
        WriteLine(!(1 == 1)); // true -> false        
    }
}
