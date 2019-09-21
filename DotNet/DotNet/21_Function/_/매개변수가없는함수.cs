using System;

public class 매개변수가없는함수
{
	public static void Main()
	{
		Console.WriteLine("1. 안녕하세요.");
		//함수 호출
		안녕하세요();
		안녕하세요();
		안녕하세요();
	}

	//매개변수(인자,인수,파라미터)가 없는 함수 : 안녕하세요
	//함수 선언
	public static void 안녕하세요()
	{
		Console.WriteLine("2. 안녕하세요.");
	}
}
