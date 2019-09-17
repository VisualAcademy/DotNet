// 5명의 학생의 국어 점수를 배열에 저장 후 총점과 평균을 구하고 
// 각 학생의 평균과의 차이를 구하는 프로그램을 작성합니다.
// 입력 값: 100, 90, 80, 70, 60
using System;

class 국어점수_총점_평균_차이
{
    static void Main()
    {
        int[] kor = { 100, 90, 80, 70, 60 };
        int tot = 0;        // 총점
        float avg = 0.0f;   // 평균
        
        for (int i = 0; i < kor.Length; i++)
        {
            tot = tot + kor[i];
        }
        avg = tot / (float)kor.Length;

        Console.WriteLine("총점: {0,3}, 평균: {1,3}\n", tot, avg);
        for (int i = 0; i < kor.Length; i++)
        {
            float diff = kor[i] - avg; // 차이
            Console.WriteLine("점수: {0,3}, 차이: {1,3}", kor[i], diff);
        }
    }
}
