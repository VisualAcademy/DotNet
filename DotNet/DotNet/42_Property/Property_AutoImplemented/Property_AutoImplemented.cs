// 자동 구현 속성(C# 3.0): prop 코드 조각
using System;

namespace Property_AutoImplemented
{
    class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    class Property_AutoImplemented
    {
        static void Main()
        {
            Exam exam = new Exam();
            exam.Id = 1;
            exam.Title = "중간고사";
            Console.WriteLine($"{exam.Id} - {exam.Title}");
        }
    }
}
