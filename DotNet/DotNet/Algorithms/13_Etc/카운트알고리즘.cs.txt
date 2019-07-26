// 5개의 정수 중에서 홀수의 개수 : 3개
using System;

public class 카운트알고리즘
{
  public static void Main(string[] args)
  {
    //[1] Init/Input
    int[] intNum = { 21, 34, 56, 27, 39 };
    int count = 0; // 카운트 저장
    //[2] Process : COUNT 알고리즘
    for (int i = 0; i < intNum.Length; i++)
    {
      if (intNum[i] % 2 != 0) // 홀수라면
      {
        count++; // 카운트(COUNT)   
      }  
    }
    //[3] Output
    Console.WriteLine("홀수의 개수 : {0}개", count);
  }
}