using System;

public class while��
{
	public static void Main()
	{
		//[1] 1���� 10���� ī��Ʈ�ϴ� ���α׷�
		int i = 1;//�ʱ��
		while(i <= 10)//����
		{
			Console.Write("{0} ", i);//��ɹ�
			i++;//������
		}
		//[2] 1���� 100���� ¦���� ���� ���ϴ� ���α׷�
		int sum = 0;
		int j = 1;					//�ʱ��
		while(j <= 100)				//����
		{
			if(j % 2 != 1)			//���͸�
			{
				sum += j;			//���๮
			}
			j = j + 1;				//������
		}
        Console.WriteLine("1~100���� ¦���� �� : {0}", sum);
	}
}