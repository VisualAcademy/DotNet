using System;

namespace PointImperative
{
    class Point
    {
        // 필드: public 필드
        public int x;
        public int y;

        // 생성자
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 메서드
        public void MoveBy(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }

    class PointImperative
    {
        static void Main()
        {
            Point point = new Point(0, 0); // 좌표 기본값 설정
            point.MoveBy(100, 200); // 100, 200으로 이동
            Console.WriteLine($"X: {point.x}, Y: {point.y}"); // 100, 200
        }
    }
}
