using System;

class TriangleAreaCalculator
{
    // 삼각형의 넓이를 계산하는 함수
    static double TriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height; // 삼각형의 넓이를 계산하여 반환
    }

    static void Main()
    {
        double baseLength, height; // 삼각형의 밑변과 높이를 저장할 변수 선언

        Console.Write("삼각형의 밑변과 높이를 입력하세요: ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        height = Convert.ToDouble(Console.ReadLine()); // 사용자로부터 밑변과 높이를 입력받음

        // 삼각형의 넓이를 계산하고 출력
        Console.WriteLine("삼각형의 넓이: {0:F2}", TriangleArea(baseLength, height));
    }
}
