using System;

public class 매개변수가있는함수
{
	public static void Main()
	{
		출력("안녕하세요.");
		출력("반갑습니다.");
		출력(1234);
	}

	public static void 출력(object 매개변수)
	{
		Console.WriteLine(
			"넘겨져 온 값 : {0}", 매개변수.ToString());		
	}
}
