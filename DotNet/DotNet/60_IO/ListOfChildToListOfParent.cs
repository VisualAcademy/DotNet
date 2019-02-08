using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfChildToListOfParent
{
    interface A { }

    class B : A { }
    
    class ListOfChildToListOfParent
    {
        static void Main()
        {
            List<A> convertAll = (new List<B>()).ConvertAll(x => (A)x); // [1]
            List<A> castOf = (new List<B>()).Cast<A>().ToList(); // [2]

            Console.WriteLine(convertAll);
            Console.WriteLine(castOf);
        }
    }
}
