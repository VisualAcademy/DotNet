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
            //[!] 자식 개체를 부토 개체로 변환시키는 2가지 구문
            List<A> convertAll = (new List<B>()).ConvertAll(x => (A)x); // [1]
            List<A> castOf = (new List<B>()).Cast<A>().ToList(); // [2]

            Console.WriteLine(convertAll);
            Console.WriteLine(castOf);
        }
    }
}
