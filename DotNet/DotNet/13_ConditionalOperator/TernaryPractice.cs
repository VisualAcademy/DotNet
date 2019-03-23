// 3항 연산자를 사용하여 합격 또는 불합격 판단하기
using System;

class TernaryPractice
{
    static void Main()
    {
        int score = 59;
        string result = "";

        result = (score >= 60) ? "합격" : "불합격";

        Console.WriteLine($"점수: {score}, 결과: {result}");
    }
}
