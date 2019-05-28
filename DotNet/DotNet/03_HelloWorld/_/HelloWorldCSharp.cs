public class HelloWorldCSharp
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World");

        int number = 1234;
        System.Console.WriteLine("{0}", number);

        double pi = 3.14;
        System.Console.WriteLine(pi);

        //[!] 1부터 100까지 3의 배수 또는 4의 배수의 합
        //[1] Input
        int sum = 0;
        //[2] Process: 알고리즘(Algorithm): 주어진 범위(for) + 주어진 조건(if)
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 || i % 4 == 0)
            {
                sum += i; // 누적(합) => 합계(SUM) 알고리즘
            }
        }
        //[3] Output
        System.Console.WriteLine("배수의 합: {0}", sum);

        //[1]
        int[] data = { 5, 4, 3, 1, 2 };
        int temp = 0; 
        //[2] 정렬: 선택 정렬, 거품 정렬
        for (int i = 0; i < 5 - 1; i++)             // 0 -> N - 1
        {
            for (int j = i + 1; j < 5; j++)         // i + 1 -> N
            {
                if (data[i] > data[j])              // ASCending(오름차순), DESCending 
                {
                    temp = data[i];         // SWAP
                    data[i] = data[j];
                    data[j] = temp; 
                }
            }
        }
        //[3]
        for (int i = 0; i < data.Length; i++)
        {
            System.Console.Write("{0}\t", data[i]);
        }
        System.Console.Write("\n");
    }
}
