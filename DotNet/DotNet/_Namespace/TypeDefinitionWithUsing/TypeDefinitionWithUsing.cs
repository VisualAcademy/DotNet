//[I] 네임스페이스 추가
using System;

namespace TypeDefinitionWithUsing
{
    //[II] Gilbut.Education.CSharp.Lecture 형식을 Project 별칭으로 줄여서 사용
    using Project = Gilbut.Education.CSharp.Lecture;

    public class TypeDefinitionWithUsing
    {
        public static void Main(string[] args)
        {
            //[1] 기본 호출
            Gilbut.Education.CSharp.Lecture l = 
                new Gilbut.Education.CSharp.Lecture();
            Console.WriteLine(l);
            //[2] using 지시문 사용 호출
            Project p = new Project();
            Console.WriteLine(p);
        }
    }
}

namespace Gilbut
{
    namespace Education
    {
        namespace CSharp
        {
            public class Lecture
            {
                public override string ToString()
                {
                    return "Lecture 클래스 호출됨";
                }
            }
        }
    }
}
