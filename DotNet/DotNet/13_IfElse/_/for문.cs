using System;           
public class for��
{
	public static void Main()
	{
		//1���� 100���� ī��Ʈ�ϴ� ���α׷�
		for(int i = 1;i <= 100;i++){
			Console.WriteLine("{0}", i);
		}
		//1~100���� ������ ���� ���ϴ� ���α׷�
		int sum = 0;//���� ������ ����
		for(int i = 1;i <= 100;i++){
			//sum = sum + i;
			sum += i;//����
		}
		Console.WriteLine("1���� 100������ �� : {0}", sum);
		//1~100���� ���� �� ¦���� ���� ���ϴ� ���α׷�
		int sum2 = 0;
		for(int i = 1;i <= 100;++i){
			if(i % 2 == 0){
				sum2 += i;//¦����...
			}
		}
		Console.WriteLine("1~100 ¦���� �� : {0}", sum2);
	}
}