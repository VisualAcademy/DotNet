// 1 - 2 + 3 - 4 + ... - 10
class 알고리즘_수열_부호변경
{
    static void Main(string[] args)
    {
        int SUM = 0;
        int I = 0;
        int S = -1;

        do
        {
            I = I + 1; // 1~10
            S = S * -1; // 1, -1, ... 토글
            SUM = SUM + (I * S); // 누적
        } while (I < 10);
        
        System.Console.WriteLine(SUM); // 누적
    }
}
