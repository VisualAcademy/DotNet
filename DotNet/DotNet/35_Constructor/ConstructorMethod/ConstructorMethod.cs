//[?] 생성자: 클래스 이름과 동일한 이름의 반환값이 없는 메서드
using System;

namespace ConstructorMethod
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student 개체가 생성됩니다.");
        }
    }

    class ConstructorMethod
    {
        static void Main()
        {
            Student student;
            student = new Student(); // 생성자를 통해서 개체를 생성
        }
    }
}
