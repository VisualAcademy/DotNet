using System;

namespace PointFunctional
{
    class Point
    {
        // readonly 필드
        public readonly int x;
        public readonly int y;

        public Point(int x, int y)
        {
            this.x = x; // readonly 필드는 반드시 생성자로 초기화 필요
            this.y = y;
        }

        //[1] 생성자의 반환값을 나 자신(Point)으로 지정 
        public Point MoveBy(int dx, int dy)
        {
            return new Point(x + dx, y + dy);
        }
    }

    class PointFunctional
    {
        static void Main()
        {
            //[A] 함수형 프로그래밍 스타일: 메서드 체이닝
            var p = (new Point(0, 0)).MoveBy(10, 10).MoveBy(20, 20).MoveBy(30, 30);
            Console.WriteLine($"X: {p.x}, Y: {p.y}"); // 60, 60
        }
    }
}
