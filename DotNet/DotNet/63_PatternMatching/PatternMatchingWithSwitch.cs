using System;
using static System.Console;

namespace PatternMatchingWithSwitch
{
    class Circle
    {
        public int Radius { get; set; } = 10;
    }

    class Rectangle
    {
        public int Length { get; set; }
        public int Height { get; set; }
    }

    class PatternMatchingWithSwitch
    {
        static void Main()
        {
            PrintShape(new Circle()); // 원
            PrintShape(new Rectangle { Length = 20, Height = 10 }); // 직사각형
            PrintShape(new Rectangle { Length = 10, Height = 10 }); // 정사각형
        }

        static void PrintShape(object shape)
        {
            switch (shape)
            {
                case Rectangle s when (s.Length == s.Height):
                    WriteLine($"정사각형: {s.Length} x {s.Height}");
                    break;
                case Rectangle r:
                    WriteLine($"직사각형: {r.Length} x {r.Height}");
                    break;
                case Circle c:
                    WriteLine($"원: 반지름({c.Radius})");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    WriteLine("<기타 도형>");
                    break;
            }
        }
    }

}