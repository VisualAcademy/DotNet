using System;           
public class for문
{
	public static void Main()
	{
		//1부터 100까지 카운트하는 프로그램
		for(int i = 1;i <= 100;i++){
			Console.WriteLine("{0}", i);
		}
		//1~100까지 정수의 합을 구하는 프로그램
		int sum = 0;//합을 저장할 변수
		for(int i = 1;i <= 100;i++){
			//sum = sum + i;
			sum += i;//누적
		}
		Console.WriteLine("1부터 100까지의 합 : {0}", sum);
		//1~100까지 정수 중 짝수의 합을 구하는 프로그램
		int sum2 = 0;
		for(int i = 1;i <= 100;++i){
			if(i % 2 == 0){
				sum2 += i;//짝수만...
			}
		}
		Console.WriteLine("1~100 짝수의 합 : {0}", sum2);
	}
}