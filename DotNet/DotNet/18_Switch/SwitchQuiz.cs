using System;

class SwitchQuiz
{
    static void Main()
    {
        string result = "";
        string color = "green";

        switch (color)
        {
            case "red":
                result = "빨강";
                break;
            case "green":
                result = "초록";
                break;
            case "blue":
                result = "파랑";
                break;
            default:
                result = "기타 색상";
                break;
        }

        Console.WriteLine($"{color}: {result}");
    }
}
