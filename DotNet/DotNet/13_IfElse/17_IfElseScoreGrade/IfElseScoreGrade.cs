using System;

class IfElseScoreGrade
{
    static void Main()
    {
        Console.Write("점수: ");
        int score = Convert.ToInt32(Console.ReadLine());

        //string grade = String.Empty;
        string grade = ""; // 상장 이름 담을 그릇 

        if (score >= 90)
        {
            grade = "금메달";
        }
        else
        {
            if (score >= 80)
            {
                grade = "은메달";
            }
            else
            {
                if (score >= 70)
                {
                    grade = "동메달";
                }
                else
                {
                    grade = "노메달";
                }
            }
        }

        Console.WriteLine($"{grade}을 수상하였습니다.");
    }
}
