using System;   
public class 예외처리{
	public static void Main(){
		int intA = 10;
		int intB = 0;        		
		int intC = 0;
		try//예외를 감시하는 문장
		{
			intC = intA / intB;
		}
		catch(Exception e)//예외가 발생했을 때 실행하는 구문
		{
			Console.WriteLine("예외가 발생했습니다.");	
			Console.WriteLine("예외내용 : {0}", e.Message);
		}
		finally//예외 처리의 마지막에 실행되는 구문
		{
			Console.WriteLine("프로그램을 종료합니다.");
		}
		Console.WriteLine("{0}", intC);
	}
}
