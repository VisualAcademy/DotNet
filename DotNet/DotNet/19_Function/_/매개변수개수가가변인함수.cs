using System;
public class �Ű������������������Լ�{
	public static void Main(){
		���();//�ȳ��ϼ���.
		���("�ݰ����ϴ�.");//�ݰ����ϴ�.
		���("������ ", "�� ������.");//������ �� ������.
	}
	public static void ���()
	{
		Console.WriteLine("�ȳ��ϼ���.");
	}
	public static void ���(string strParameter)
	{
		Console.WriteLine(strParameter);//�Ѱ��� �� �� ���	
	}
	public static void ���(string strA, string strB)
	{
		Console.WriteLine(strA + strB);//��� ���
	}
}
