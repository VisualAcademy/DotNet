// switch 문: 선택문
using System;

class SwitchWeather
{
    static void Main()
    {
        Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
        string weather = Console.ReadLine();

        switch (weather)
        {
            case "맑음":
                Console.WriteLine("오늘 날씨는 맑군요.");
                break;
            case "흐림":
                Console.WriteLine("오늘 날씨는 흐리군요.");
                break;
            case "비":
                Console.WriteLine("오늘 날씨는 비가 오는군요.");
                break;
            default:
                Console.WriteLine("혹시 눈이 내리나요?");
                break;
        }
    }
}
