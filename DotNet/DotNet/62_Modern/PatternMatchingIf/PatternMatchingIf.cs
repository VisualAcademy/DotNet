using System;

namespace PatternMatchingIf
{
    class Shape { }

    class Rectangle : Shape
    {
        public string Name { get; set; } = "사각형";
    }

    class PatternMatchingIf
    {
        static void Main() => ShowShape(new Rectangle());

        static void ShowShape(Shape shape)
        {
            // [1] if 구문을 사용한 패턴 매칭
            if (shape is Rectangle r)
            {
                Console.WriteLine(r.Name);
            }
        }
    }
}
