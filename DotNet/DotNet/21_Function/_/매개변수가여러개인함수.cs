using System;                    
public class �Ű����������������Լ�{
	public static void Main(){
		�հ�(3, 8);//11
		���(3, 8, "-");//-5
		���(3, 8, "%");//3
	}                                  
	public static void �հ�(int a, int b){
		int c = a + b;
		Console.WriteLine(
			"�Ѱ��� �� {0} + {1} = {2}�Դϴ�.", a, b, c);
	}                                   
	public static void ���(int a, int b, string strOperator){
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
			"�Ѱ��� �� {0} {1} {2} = {3}�Դϴ�.", 
			a, strOperator, b, intResult);
	}
}
