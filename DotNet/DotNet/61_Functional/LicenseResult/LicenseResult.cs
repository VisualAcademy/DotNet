using System;

class LicenseResult
{
    //[1] 문(Statement)을 사용하여 시험 결과 판정
    static string GetResultWithStatement(int score)
    {
        string r;
        if (score >= 60)
        {
            r = "합격";
        }
        else
        {
            r = "불합격";
        }
        return r; // 변하는 값 반환
    }

    //[2] 식(Expression)을 사용하여 시험 결과 판정
    static string GetResultWithExpression(int score) =>
        score >= 60 ? "합격" : "불합격"; // 변하지 않는 값 반환

    static void Main()
    {
        //[A] 문 호출
        Console.WriteLine(GetResultWithStatement(60)); // 합격

        //[B] 식 호출
        Console.WriteLine(GetResultWithExpression(60)); // 합격
    }
}
