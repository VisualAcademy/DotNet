//>, <, >=, <=, ==(같은지), !=(다른지)
using System;
public class 관계연산자
{
	public static void 관계()
	{
		int 정수1 = 10;
		int 정수2 = 5;
		Console.WriteLine(
			"정수1 > 정수2 : {0}", (정수1>정수2));//true
		Console.WriteLine(
			"정수1 == 정수2 : {0}", (정수1==정수2));//false
		Console.WriteLine(
			"정수1 != 정수2 : {0}", (정수1!=정수2));//true
	}
}