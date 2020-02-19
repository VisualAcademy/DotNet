using System;

public class while문
{
	public static void Main()
	{
		//[1] 1부터 10까지 카운트하는 프로그램
		int i = 1;//초기식
		while(i <= 10)//논리식
		{
			Console.Write("{0} ", i);//명령문
			i++;//증감식
		}
		//[2] 1부터 100까지 짝수의 합을 구하는 프로그램
		int sum = 0;
		int j = 1;					//초기식
		while(j <= 100)				//논리식
		{
			if(j % 2 != 1)			//필터링
			{
				sum += j;			//실행문
			}
			j = j + 1;				//증감식
		}
        Console.WriteLine("1~100까지 짝수의 합 : {0}", sum);
	}
}