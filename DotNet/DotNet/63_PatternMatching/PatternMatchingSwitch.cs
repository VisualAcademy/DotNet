using System;

namespace PatternMatchingSwitch
{
    class Shape { }

    class Rectangle : Shape { }

    class Circle : Shape { }

    class PatternMatchingSwitch
    {
        static void Main()
        {
            ShowShape(new Circle());        // 원
            ShowShape(new Rectangle());     // 사각형
        }

        static void ShowShape(Shape shape)
        {
            switch (shape)
            {
                case Circle s:
                    Console.WriteLine("원");
                    break;
                case Rectangle r:
                    Console.WriteLine("사각형");
                    break;
            }
        }
    }
}
