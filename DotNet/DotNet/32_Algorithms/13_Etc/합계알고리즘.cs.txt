// 5개의 자료 중 짝수의 합 : 6
using System;

public class 합계알고리즘
{
  public static void Main(string[] args)
  {
    //[1] Init/Input
    int[] intNum = { 1, 2, 3, 4, 5 };
    int sum = 0; // 합계 저장
    //[2] Process : 알고리즘
    for (int i = 0; i < intNum.Length; i++)
    {
      if (intNum[i] % 2 == 0) // 배열의 값이 짝수라면...
      {
        sum += intNum[i]; // 짝수만 누적(SUM)  
      }  
    }
    //[3] Output
    Console.WriteLine("짝수의 합 : {0}", sum);
  }
}