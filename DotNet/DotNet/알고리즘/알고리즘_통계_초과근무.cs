using System;

class 알고리즘_통계_초과근무
{
    static void Main()
    {
        int TOT = 0; // 총합
        float AVG = 0F; // 평균
        int DAN = 0; // 시급
        int OTI = 0; // 오버타임
        int SU = 0; // 카운트 => SU = SU + 1;
        int WAMT = 0; // 주간급여
        string ID = "";
        byte GD = 0;
        int TI = 0;
        string eof = "";
        while (eof != "EOF")
        {
            Console.Write("아이디: _\b");
            ID = Console.ReadLine();
            Console.Write("등급(1,2,3): _\b");
            GD = Convert.ToByte(Console.ReadLine()); // 1, 2, 3 
            Console.Write("근무시간: _\b");
            TI = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"아이디: {ID}, 등급: {GD}, 근무시간: {TI}");

            if (GD == 1)
            {
                DAN = 10000;
            }
            else if (GD == 2)
            {
                DAN = 5000;
            }
            else
            {
                DAN = 2000;
            }

            if (TI < 36)
            {
                OTI = 0; 
            }
            else if (TI < 50)
            {
                OTI = TI - 36; 
            }
            else
            {
                OTI = 14; 
            }

            WAMT = (int)(TI * DAN + (OTI * DAN * 1.5));

            Console.WriteLine($"아이디: {ID}, 주간급여: {WAMT}");

            TOT = TOT + WAMT; // 총합
            SU = SU + 1; // 카운트

            Console.WriteLine("계속할꺼면 Y?");
            string r = Console.ReadLine();
            if (r != "Y")
            {
                eof = "EOF";
            }
        }
        AVG = TOT / (float)SU;

        Console.WriteLine($"평균: {AVG}");
    }
}
