//&&������(And) : �� �� ���� ������ ��, ��, �ϳ��� �����̸� ����
//||������(Or) : �ϳ��� ���̸� ��, ��, �Ѵ� ������ ������ ����
//!������(Not)  : ���̸� ��������, �����̸�, ������
using System;
public class ��������
{
	public static void ��()
	{
		int i = 3;		int j = 5;
		Console.WriteLine( (i == 3) && (j != 3) );//true
		Console.WriteLine( (i != 3) || (j == 3) );//false
		Console.WriteLine( !(i != 3) );//false -> true
	}
}
