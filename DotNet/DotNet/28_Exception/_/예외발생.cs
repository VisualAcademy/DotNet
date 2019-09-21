using System;

public class 예외발생
{
	public static void Main()
	{
		//[1]컴파일 오류
		//int intNumber = 10 / 0;//예외 발생
		//Console.WriteLine("{0}", intNumber);

		//[2]런타임 오류
		int intA = 10;
		int intB = 0;
		int intC = intA / intB;
        Console.WriteLine("{0}", intC);
	}
}
