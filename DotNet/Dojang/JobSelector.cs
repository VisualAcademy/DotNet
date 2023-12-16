using System;

namespace JobSelector
{
    enum Job
    {
        Developer,
        Instructor,
        Author
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("1. Developer");
            Console.WriteLine("2. Instructor");
            Console.WriteLine("3. Author");

            int choice = Convert.ToInt32(Console.ReadLine());
            Job myJob;

            switch (choice)
            {
                case 1:
                    myJob = Job.Developer;
                    break;
                case 2:
                    myJob = Job.Instructor;
                    break;
                case 3:
                    myJob = Job.Author;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return;
            }

            Console.WriteLine($"선택한 직업: {myJob}");
        }
    }
}
