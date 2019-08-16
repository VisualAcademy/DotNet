
class 알고리즘_배열채우기_오른쪽삼각형
{
    static void Main()
    {
        int[] TMP = new int[20]; // 0번째 무시

        TMP[1] = 2;
        TMP[2] = 3; 

        int P, Q, K = 0;
        int MOK = 0; // 몫
        int NAM = 0; // 나머지

        int CNT = 2; // 개수

        for (P = 5; P <= 1000; P = P + 2)
        {
            for (Q = 2; Q <= CNT; Q++)
            {
                MOK = P / TMP[Q]; // 3으로 나누었을 때 몫, 5 / 3 = 1
                NAM = P - MOK * TMP[Q]; // 나머지  

                if (NAM == 0)
                {
                    // 소수가 아니다. 
                    goto 여기;
                }
            }
            CNT = CNT + 1; // 소수 하나 증가 
            TMP[CNT] = P; //[3] 5가 소수 

            if (CNT == 15)
            {
                break;
            }
            여기:;
        }

        int[,] A = new int[7, 7]; 
        CNT = 1;
        for (P = 1; P <= 5; P++)
        {
            K = 6 - P; 
            for (Q = K; Q <= 5; Q++)
            {
                A[P, Q] = TMP[CNT]; // 2, 3, 5
                CNT = CNT + 1; 
            }
        }

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                System.Console.Write("{0}\t", A[i, j]);
            }
            System.Console.WriteLine();
        }        
    }
}
