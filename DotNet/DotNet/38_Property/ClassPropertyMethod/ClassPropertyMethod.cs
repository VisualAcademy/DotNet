using System;

namespace ClassyPropertyMethod
{
    // 클래스
    class Point
    {
        // 속성
        public int X { get; set; } = 100;
        public int Y { get; set; } = 200; 
        // 메서드(함수)
        public void Draw() => Console.WriteLine($"X: {this.X}, Y: {this.Y}");
    }

    class ClassyPropertyMethod
    {
        static void Main() => (new Point()).Draw();
    }
}
