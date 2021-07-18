using System;

class 알고리즘_수열_알고리즘기능사20060827
{
    static void Main(string[] args)
    {
        //[1] Input
        int P = 0;
        int Q = 0;
        int M = 0;
        int H = 0;
        //[2] Process
        do
        {
            P = P + 1;
            Q = 78 - P;
            M = (P * Q);
            H = H + M;
        } while (P < 77);
        //[3] Output
        Console.WriteLine(
            "(77*1) + (76*2) + ... + (1 * 77) = {0}", H);
    }
}
