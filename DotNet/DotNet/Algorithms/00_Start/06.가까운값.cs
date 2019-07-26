// 가까운값(NEAR) : 차이값의 절대값의 최소값...
using System;
public class 가까운값 {
    public static void Main() {
        //[1] Input
        int[] data = { 10, 20, 30, 27, 17 };
        int target = 25; // target과 가까운 값
        int near = 0; // 가까운값 : 27
        int min = Int32.MaxValue; // 차이값의 절대값의 최소값
        //[2] Process : NEAR
        for (int i = 0; i < data.Length; i++) {
            if (Abs(data[i] - target) < min) {
                min = Abs(data[i] - target); // 최소값 알고리즘
                near = data[i]; // 최종적으로 가까운값 
            }    
        }
        //[3] Output
        Console.WriteLine("{0}와 가까운값 : {1}", target, near); // 25,27
    }
    public static int Abs(int num) {
        return (num < 0) ? -num : num; 
    }
}