using System;

class CircleArea
{
    // 원주율 상수 정의
    const double PI = 3.14159265;

    // CalculateCircleArea 메소드: 반지름 값을 인수로 받아 원의 넓이를 계산하여 반환하는 메소드
    static double CalculateCircleArea(double radius)
    {
        return PI * radius * radius; // 원의 넓이 공식: PI * 반지름 * 반지름
    }

    static void Main()
    {
        double radius; // 원의 반지름을 저장할 변수 선언

        // 사용자에게 원의 반지름을 입력 받기
        Console.Write("원의 반지름을 입력하세요: ");
        radius = Convert.ToDouble(Console.ReadLine());

        // 원의 넓이를 계산한 후, 소수점 둘째 자리까지 출력
        Console.WriteLine($"원의 넓이: {CalculateCircleArea(radius):0.00}");
    }
}
