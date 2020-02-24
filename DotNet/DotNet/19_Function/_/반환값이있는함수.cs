using System;

public class 반환값이있는함수
{
	public static void Main()
	{
		int intReturnValue = 합(3, 5);//반환값이 있는 경우.
		Console.WriteLine("3과 5의 합 : {0}", intReturnValue);
	}

	public static int 합(int a, int b)
	{
		int intReturnValue = a + b;
		return intReturnValue;//반환값
	}
}
