// 1/2 - 2/3 + 3/4 - 4/5 + ... + 99/100 = ???
using System;

public class 분수합계
{
  public static void Main()
  { 
    //[1] Initialize/Input
    double sum = 0.0;
    //[2] Process : 알고리즘 : 합계
    for (int i = 1; i <= 99; i++) // 99 반복
    {
      if (i % 2 == 1) // 홀수라면
      {
        sum += (i / (double)(i + 1));  
      }
      else
      {
        sum -= (i / (double)(i + 1));  
      }
    }
    //[3] Output
    Console.WriteLine("합계 : {0}", sum);//0.688
  }
}