using System;
using static System.Console;

class LogicalOperator
{
    static void Main()
    {
        int i = 3;
        int j = 5;
        bool r = false;

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
