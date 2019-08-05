using System;
using System.Linq;

public class 합계카운트평균 {
    public static void Main() {
        // Input
        int[] data = {3, 5, 4, 2, 1};
        // Process
        var q = from d in data
                where d % 2 == 0
                select d;
        int sum = q.Sum(); // 합계
        int cnt = q.Count(); // 카운트
        int avg = Convert.ToInt32(q.Average()); // 평균   
        int max = (from d in data select d).Max(); // 최댓값
        int min = (from d in data select d).OrderByDescending(p => p).Last();
        // Output
        Console.WriteLine(
            "합계 : {0}\n카운트 : {1}\n평균 : {2}", sum, cnt, avg);
        Console.WriteLine("최댓값 : {0}", max);
        Console.WriteLine("최솟값 : {0}", min);
    }    
}