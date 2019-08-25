//아래 수열의 결과값을 구하는 프로그램을 작성하시오.
//1 - 2 + 3 - 4 + 5 - ... + 99 - 100 = ?
//패턴 : 홀수는 +, 짝수는 -
using System;

public class 간단수열 {
    public static void Main() {
        //[1] Input
        int sum = 0;
        //[2] Process
        for (int i = 1; i <= 100; i++) {
            if (i % 2 != 0) {
                sum += i; 
            }
            else {
                sum -= i; 
            }
        }
        //[3] Output
        Console.WriteLine("Result : {0}", sum);
    }    
}