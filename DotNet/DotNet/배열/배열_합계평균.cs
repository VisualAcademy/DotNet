class 배열_합계평균
{
    static void Main(string[] args)
    {
        int[] kor = new int[3];
        int sum = 0;
        float avg = 0;

        kor[0] = 100;
        kor[1] = 90;
        kor[2] = 80;

        sum = kor[0] + kor[1] + kor[2];     // 총점
        avg = sum / (float)3.0;             // 평균

        System.Console.WriteLine($"총점: {sum}, 평균: {avg:0.00}");                             
    }
}
