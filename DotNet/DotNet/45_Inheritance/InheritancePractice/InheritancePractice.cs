using System;

namespace InheritancePractice
{
    class Developer
    {
        public override string ToString()
        {
            return "개발자";
        }
    }

    class WebDeveloper : Developer
    {
        public override string ToString()
        {
            return "웹 개발자";
        }
    }

    class MobileDeveloper : Developer
    {
        public override string ToString()
        {
            return "모바일 개발자";
        }
    }

    class InheritancePractice
    {
        static void Main()
        {
            Developer web = new WebDeveloper();
            Console.WriteLine(web); // 웹 개발자

            Developer mobile = new MobileDeveloper();
            Console.WriteLine(mobile); // 모바일 개발자
        }
    }
}
