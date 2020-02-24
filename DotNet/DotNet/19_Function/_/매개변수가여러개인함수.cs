using System;                    
public class 매개변수가여러개인함수{
	public static void Main(){
		합계(3, 8);//11
		계산(3, 8, "-");//-5
		계산(3, 8, "%");//3
	}                                  
	public static void 합계(int a, int b){
		int c = a + b;
		Console.WriteLine(
			"넘겨져 온 {0} + {1} = {2}입니다.", a, b, c);
	}                                   
	public static void 계산(int a, int b, string strOperator){
		double intResult = 0;
		switch(strOperator){
			case "+":intResult = a + b;break;
			case "-":intResult = a - b;break;
			case "*":intResult = a * b;break;
			case "/":intResult = a / b;break;
			case "%":intResult = a % b;break;
			default: intResult = 0;break;
		}
		Console.WriteLine(
			"넘겨져 온 {0} {1} {2} = {3}입니다.", 
			a, strOperator, b, intResult);
	}
}
