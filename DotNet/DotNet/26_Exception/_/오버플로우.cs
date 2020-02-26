//오버플로우 : 연산결과값이 범위를 벗어났을때
using System;

public class 오버플로우
{
	public static void Main()
	{
		byte 바이트형변수 = 255;
		checked
		{
			바이트형변수++;//오버플로우(overflow)
		}
//		unchecked
//		{
//			바이트형변수++;//오버플로우(overflow)
//		}
		Console.WriteLine("{0}", 바이트형변수);//256?
	}
}
