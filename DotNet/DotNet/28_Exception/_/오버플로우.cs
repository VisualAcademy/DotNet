//�����÷ο� : ���������� ������ �������
using System;

public class �����÷ο�
{
	public static void Main()
	{
		byte ����Ʈ������ = 255;
		checked
		{
			����Ʈ������++;//�����÷ο�(overflow)
		}
//		unchecked
//		{
//			����Ʈ������++;//�����÷ο�(overflow)
//		}
		Console.WriteLine("{0}", ����Ʈ������);//256?
	}
}
