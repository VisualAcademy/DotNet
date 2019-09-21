using System;
public class 매개변수개수가가변인함수{
	public static void Main(){
		출력();//안녕하세요.
		출력("반갑습니다.");//반갑습니다.
		출력("다음에 ", "또 만나요.");//다음에 또 만나요.
	}
	public static void 출력()
	{
		Console.WriteLine("안녕하세요.");
	}
	public static void 출력(string strParameter)
	{
		Console.WriteLine(strParameter);//넘겨져 온 값 출력	
	}
	public static void 출력(string strA, string strB)
	{
		Console.WriteLine(strA + strB);//묶어서 출력
	}
}
