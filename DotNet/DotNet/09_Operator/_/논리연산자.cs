//&&연산자(And) : 둘 다 참일 때에만 참, 즉, 하나라도 거짓이면 거짓
//||연산자(Or) : 하나라도 참이면 참, 즉, 둘다 거짓일 때에만 거짓
//!연산자(Not)  : 참이면 거짓으로, 거짓이면, 참으로
using System;
public class 논리연산자
{
	public static void 논리()
	{
		int i = 3;		int j = 5;
		Console.WriteLine( (i == 3) && (j != 3) );//true
		Console.WriteLine( (i != 3) || (j == 3) );//false
		Console.WriteLine( !(i != 3) );//false -> true
	}
}
