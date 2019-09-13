using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;
        }
        catch (Exception ex) // ex 변수에는 예외에 대한 상세 정보가 담김
        {            
            Console.WriteLine(ex.Message);
        }
    }
}
