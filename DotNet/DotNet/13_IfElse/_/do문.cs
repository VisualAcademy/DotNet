using System;

public class do��
{
	public static void Main()
	{
		//1���� 100���� ���� �� ¦���� ���� ���ϴ� ���α׷�
		int sum = 0;
		int i = 1;//�ʱ�� : 1����...
		do
		{
			if(i % 2 == 0)
			{
				sum += i;//���๮ : ����		
			}
			i = i + 1;//������
		}while(i <= 100);//���ǽ� : 100����..
		Console.WriteLine("1~100���� ¦���� �� : {0}", sum);
	}
}