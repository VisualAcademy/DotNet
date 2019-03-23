// (1*2)+(1*2*3)+...
class 알고리즘_수열_팩토리얼
{
    static void Main(string[] args)
    {
        int SUM = 0;
        int I = 1; // 1증가 변수
        int F = 1; //[1] 팩토리얼 결과 기억 변수

        do 
        {
            I = I + 1; //[2] 2, 3

            if (I < 21) //[3] 21
            {
                F = I * F; //[4] 3*(2*1)
                SUM = SUM + F; //[5] SUM = (2*1) + (3*(2*1))
            }
            else
            {
                break;
            }

        } while (true);

        System.Console.WriteLine(SUM);
    }
}
