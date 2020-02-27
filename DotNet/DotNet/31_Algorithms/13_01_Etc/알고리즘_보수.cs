class 알고리즘_보수
{
    static void Main()
    {
        int[] arr = { 0, 1, 0, 1, 1, 1 }; // 010111
        int[] comp1 = new int[6];
        int[] comp2 = new int[6];
        int p = 0;
        int c = 1; //[1] 

        do
        {
            p = p + 1;
            comp1[p] = 1 - arr[p]; //[2] 1의 보수 : 0 <=> 1
        } while (p < 5);

        do
        {
            comp2[p] = comp1[p] + c; //[3] 올림수 더하기 
            comp2[p] = comp2[p] % 2; //[4] 나머지 값
            c = comp1[p] * c; // 캐리 구하기 
            p = p - 1; 
        } while (p != 0);


        for (int i = 0; i < 6; i++)
        {
            System.Console.Write("{0}, ", comp2[i]);
        }
        System.Console.WriteLine();
    }
}
