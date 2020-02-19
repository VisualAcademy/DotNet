using System;
public class 조건문{
	public static void 조건(){
		int 입력된숫자 = 9;
		//[1]if문
		if(입력된숫자 % 2 == 1){
			Console.WriteLine("{0}는 홀수입니다.", 입력된숫자);
		}
		//[2]else문
		if(입력된숫자 % 2 == 0){
			Console.WriteLine("{0}는 짝수입니다.", 입력된숫자);
		}
		else{
			Console.WriteLine("{0}는 홀수입니다.", 입력된숫자);
		}
		//[3]else if문
		if(입력된숫자 % 3 == 0){
			Console.WriteLine("{0}는 3의 배수입니다.", 입력된숫자);
		}
		else if(입력된숫자 % 4 == 0){
			Console.WriteLine("{0}는 4의 배수입니다.", 입력된숫자);
		}
		else if(입력된숫자 % 5 == 0){
			Console.WriteLine("{0}는 5의 배수입니다.", 입력된숫자);
		}
		else{
			Console.WriteLine(
				"{0}는 3, 4, 5의 배수가 아닙니다.", 입력된숫자);
		}
	}
}
