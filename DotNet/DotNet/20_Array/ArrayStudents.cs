// 3명의 학생의 점수를 입력받아 총점을 구하는 프로그램
using System;

class ArrayStudents
{
    static void Main()
    {
        // 3개의 요소를 가지는 1차원 배열 생성
        int[] students = new int[3];

        // 사용자로부터 정수 데이터 3개 입력받아 배열에 저장
        students[0] = Convert.ToInt32(Console.ReadLine());
        students[1] = Convert.ToInt32(Console.ReadLine());
        students[2] = Convert.ToInt32(Console.ReadLine());

        // 총점 구하고 출력하기 
        int total = students[0] + students[1] + students[2];
        Console.WriteLine($"총점: {total}");
    }
}
