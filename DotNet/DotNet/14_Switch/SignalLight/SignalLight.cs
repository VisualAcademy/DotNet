using System;

class SignalLight
{
    static void Main()
    {
        char signalLight = 'A';
        string message = "";

        switch (signalLight)
        {
            case 'R':
                message = "적색: 멈추세요.";
                break;
            case 'Y':
                message = "황색: 주의하세요.";
                break;
            case 'G':
                message = "녹색: 이동하세요.";
                break;
            default:
                message = "신호등 고장";
                break;
        }

        Console.WriteLine(message);
    }
}
