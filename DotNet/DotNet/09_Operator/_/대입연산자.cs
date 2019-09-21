//=연산자
//+=연산자(누적)
using System;
public class 대입연산자
{
	public static void 대입()
	{
		int a = 3;//일반적인 모든 대입
		int b = 5;
		//b = b + a;//b = 8
		b += a;//누적:b변수와 a변수를 더해서 그 값을 b변수에 대입
		Console.WriteLine("{0}", b);//8
	}
}
