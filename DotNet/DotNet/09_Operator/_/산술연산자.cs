using System;
public class 산술연산자//%연산자 : 나머지 연산자. 몫을 구하지않고 나머지.
{
	public static void 산술계산()
	{
		int a = 5;
		int b = 3;
		Console.WriteLine(a + b);//8
		Console.WriteLine(
			"a % b 는 {0}입니다.", (a % b));//몫:1, 나머지:2
	}
}
