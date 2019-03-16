// 메서드 구문(Method Syntax)과 쿼리 구문(Query Syntax) 비교
using System;
using System.Collections.Generic;
using System.Linq;

class LinqQuerySyntax
{
    static void Main()
    {
        int[] numbers = { 3, 2, 1, 4, 5 };

        //[1] 메서드 구문
        IEnumerable<int> methodSyntax = 
            numbers.Where(n => n % 2 == 1).OrderBy(n => n);

        foreach (var n in methodSyntax)
        {
            Console.WriteLine(n);
        }

        //[2] 쿼리 구문
        IEnumerable<int> querySyntax =
            from num in numbers
            where num % 2 == 1
            orderby num
            select num;

        foreach (var n in querySyntax)
        {
            Console.WriteLine(n);
        }
    }
}
