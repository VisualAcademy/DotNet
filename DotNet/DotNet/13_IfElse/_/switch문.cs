//switch�� == ���� if��
using System;

public class switch��
{
	public static void Main()
	{
		//�ð��� ����ϴ� ��ɾ� : DateTime.Now.Hour
		string strDate = DateTime.Now.Hour.ToString();//����ð�
		Console.WriteLine("���� �ð� : {0}��", strDate);
		
		switch(strDate)
		{
			case "21":
				Console.WriteLine("���� ���±���...");
				break;
			case "22":
				Console.WriteLine("���� ���ڸ��� �� �ð��Դϴ�...");
				break;
			case "06":
				Console.WriteLine("���� ��ħ�Դϴ�...");
				break;
			default:
				Console.WriteLine("��Ÿ �ٸ� �ð���...");
				break;
		}
	}
}
