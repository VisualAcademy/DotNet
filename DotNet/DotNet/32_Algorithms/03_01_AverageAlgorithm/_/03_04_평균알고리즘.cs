using System;

public class 평균알고리즘
{
  public static void Main(string[] args)
  {
    //[1] Init/Input
    int[] intNum = { 1, 2, 3, 4, 5 };
    double avg = 0.0; // 평균 저장 변수
    int sum = 0;
    int count = 0;
    //[2] Process
    for (int i = 0; i < intNum.Length; i++)
    {
      if (intNum[i] % 2 != 1)
      {
        sum += intNum[i]; // SUM
        count++; // COUNT
      }  
    }
    avg = sum / (double)count; // 실수형으로 나누기
    //[3] Output
    Console.WriteLine("짝수의 평균 : {0}", avg);
  }
}