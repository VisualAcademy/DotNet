//[?] 개체 이니셜라이저(C# 3.0 특징) 
using System;

namespace ObjectInitializer
{
    class Course
    {
        public int Id { get; set; } // Id 속성
        public string Title { get; set; } // Title 속성
    }

    class ObjectInitializer
    {
        static void Main()
        {
            //[1] 속성을 사용하여 개체 초기화
            Course csharp = new Course(); csharp.Id = 1; csharp.Title = "C#";
            Console.WriteLine($"{csharp.Id} - {csharp.Title}");

            //[2] 개체 이니셜라이저를 사용하여 개체 초기화
            Course aspnet = new Course() { Id = 2, Title = "ASP.NET" };
            Console.WriteLine($"{aspnet.Id} - {aspnet.Title}");
        }
    }
}
