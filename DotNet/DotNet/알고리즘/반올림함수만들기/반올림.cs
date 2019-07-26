using System;

public class 반올림
{
    public static void Main() {
        double d = 1234.5678;
        Console.WriteLine( Math.Round(d, 2) ); // 1234.57
        Console.WriteLine( MyRound(d, 3) ); // 1234.57
        //double temp = (int)((d + 0.05) * 10) / 10.0; // XXX.X
        double temp = (int)((d + 0.005) * 100) / 100.0; // XXX.XX
        Console.WriteLine("{0}", temp);
    }
    /// <summary>
    /// 내가 만든 반올림 함수
    /// </summary>
    /// <param name="num">실수형</param>
    /// <param name="pos">자릿수 : 반올림되어질 자리</param>
    /// <returns>반올림된 수</returns>
    public static double MyRound(double num, int pos) {
        //[1]
        double result = 0.0;
        double half = 0.5;
        double factor = 1; 
        //[2]
        for (int i = 0; i < pos; i++) {
            half *= 0.1;
            factor *= 10; 
        }
        result = (int)((num + half) * factor) / (double)factor; 
        //[3]
        return result; 
    }
}