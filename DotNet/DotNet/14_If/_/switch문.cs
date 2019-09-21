//switch문 == 다중 if문
using System;

public class switch문
{
	public static void Main()
	{
		//시간을 출력하는 명령어 : DateTime.Now.Hour
		string strDate = DateTime.Now.Hour.ToString();//현재시간
		Console.WriteLine("현재 시간 : {0}시", strDate);
		
		switch(strDate)
		{
			case "21":
				Console.WriteLine("밤이 깊어가는군요...");
				break;
			case "22":
				Console.WriteLine("이제 잠자리에 들 시간입니다...");
				break;
			case "06":
				Console.WriteLine("좋은 아침입니다...");
				break;
			default:
				Console.WriteLine("기타 다른 시간대...");
				break;
		}
	}
}
