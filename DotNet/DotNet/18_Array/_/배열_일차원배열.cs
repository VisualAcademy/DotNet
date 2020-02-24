using System;

public class 배열_일차원배열
{
    public static void Main()
    {
        //[!] 변수
        int variable = 1234;
        Console.WriteLine($"변수 값 출력: {variable}");

        //[1] 배열 선언
        int[] array;

        //[2] 배열 요소수 생성
        array = new int[3];
        
        //[3] 배열 초기화
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;

        //[4] 배열 출력
        Console.WriteLine("배열 값 출력: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }        
        
        //[!] 배열(Array) 선언과 동시에 초기화
        int[] arr = { 10, 20, 30 };
        Console.WriteLine("{0}, {1}, {2}", arr[0], arr[1], arr[2]);

        int[] a = new int[3];
        a[0] = 10; a[1] = 20; a[2] = 30;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0}", a[i]);
        }

        string[] sites = new string[] {"데브렉", "닷넷코리아", "비주얼아카데미" };
        for (int i = 0; i < sites.Length; i++)
        {
            Console.Write("{0}\t", sites[i]);
        }
        Console.WriteLine();
    }
}
