using System;

class CelsiusToFahrenheitWithFunction
{
    // 섭씨를 화씨로 변환하는 함수 선언
    static float CelsiusToFahrenheit(float celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        float celsius, fahrenheit; // 섭씨 온도와 화씨 온도를 저장할 변수 선언
        Console.Write("섭씨 온도를 입력하세요: ");
        celsius = float.Parse(Console.ReadLine()); // 사용자로부터 섭씨 온도를 입력받음

        // 섭씨 온도를 화씨 온도로 변환
        fahrenheit = CelsiusToFahrenheit(celsius);

        // 화씨 온도를 소수점 둘째 자리까지 출력
        Console.WriteLine($"화씨 온도: {fahrenheit:F2}");
    }
}
