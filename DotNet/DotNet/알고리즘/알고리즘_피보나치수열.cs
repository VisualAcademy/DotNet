// Y=1+1+2+3+5+8+13+21+34+…
// Y=1+1+2+3 
class 알고리즘_피보나치수열
{
    static void Main()
    {
        int A = 1;
        int B = 1;
        int Y = 2; 

        int C = 0;
        int N = 4;

        for (int K = 3; K <= N; K++)
        {
            C = A + B; // (1 + 1) => 2
            Y = Y + C;
            A = B;
            B = C; 
        }
    }
}
