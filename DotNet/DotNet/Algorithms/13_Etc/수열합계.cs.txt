// 1 - 2 + 3 - 4 + 5 - ... + 99 - 100 = ???
// 위 수열을 계산하는 프로그램을 작성하시오.
using System;

public class 수열합계
{
  public static void Main()
  { 
    //[1] Init/Input
    int sum = 0;
    //[2] Process : SUM
    for (int i = 1; i <= 100; i++)
    {
      if (i % 2 == 1) // 홀수라면...
      {
        sum += i;  // 누적(+)
      }
      else
      {
        sum -= i;//가감(-)
      }
    }
    //[3] Output
    Console.WriteLine("합계 : {0}", sum);//-50
  }
}