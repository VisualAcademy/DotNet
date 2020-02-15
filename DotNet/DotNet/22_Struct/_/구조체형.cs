using System;

public struct 명함
{
	public string 이름;
	public int 나이;
}              

public class 구조체형
{
	public static void Main()
	{
		//인스턴스 생성 : 명함 구조체를 사용
		명함 명함구조체;
		//데이터 입력
		명함구조체.이름 = "홍길동";
		명함구조체.나이 = 21;
		//데이터 출력
		Console.WriteLine(명함구조체.이름);
		Console.WriteLine(명함구조체.나이);
	}
}