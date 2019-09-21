using System;

public class do문
{
	public static void Main()
	{
		//1부터 100까지 정수 중 짝수의 합을 구하는 프로그램
		int sum = 0;
		int i = 1;//초기식 : 1부터...
		do
		{
			if(i % 2 == 0)
			{
				sum += i;//실행문 : 누적		
			}
			i = i + 1;//증감식
		}while(i <= 100);//조건식 : 100까지..
		Console.WriteLine("1~100까지 짝수의 합 : {0}", sum);
	}
}