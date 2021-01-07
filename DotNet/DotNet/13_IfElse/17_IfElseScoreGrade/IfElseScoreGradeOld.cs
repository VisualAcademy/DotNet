using System;

class IfElseScoreGradeOld
{
    static void Main()
    {
        Console.Write("점수: ");
        int score = Convert.ToInt32(Console.ReadLine());
        string grade = "";

        if (score >= 90)
        {
            grade = "금상";
        }
        else
        {
            if (score >= 80)
            {
                grade = "은상";
            }
            else
            {
                if (score >= 70)
                {
                    grade = "동상";
                }
                else
                {
                    grade = "장려상";
                }
            }
        }

        Console.WriteLine($"{grade}을 수상하였습니다.");
    }
}
