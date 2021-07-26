/*
 * .NET Class의 Stack 클래스 사용	 
*/
using System;
using System.Collections;

public class 스택
{
	public static void Main()
	{
		//[1] 스택 인스턴스 생성
		Stack stack = new Stack();

		//[2] Push
		Console.WriteLine("Push : C언어");
		stack.Push("C언어");
		Console.WriteLine("Push : C#");
		stack.Push("C#");

		Console.WriteLine("===============");

		//[3] Pop
		Console.WriteLine("Pop : {0}", stack.Pop());
		Console.WriteLine("Pop : {0}", stack.Pop());
	}
}
