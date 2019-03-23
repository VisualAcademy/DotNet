using System;

class ArrayTotalAvg
{
    static void Main()
    {
        int[] kor = new int[3]; // 3개의 int 형식 요소를 갖는 1차원배열 선언
        int sum = 0; // 합계가 담길 변수 sum 선언과 동시에 0으로 초기화
        float avg = 0; // 평균이 담길 실수형 변수 avg 선언과 동시에 0으로 초기화

        kor[0] = 100; // 배열의 각 요소에 값 대입
        kor[1] = 90;
        kor[2] = 80;

        sum = kor[0] + kor[1] + kor[2];     // 총점 계산
        avg = sum / (float)3.0;             // 평균 계산

        // 총점과 평균 출력: 평균은 소수점 2자리까지 출력
        Console.WriteLine($"총점: {sum}, 평균: {avg:0.00}");
    }
}
