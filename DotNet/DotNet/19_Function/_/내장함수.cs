using System;

public class 내장함수
{
	public static void Main()
	{
		int i = 10;
		string j = "안녕하세요...";
		string k = i.ToString() + j;//ToString() : 오브젝트->문자열
		Console.WriteLine(k);
	}
}