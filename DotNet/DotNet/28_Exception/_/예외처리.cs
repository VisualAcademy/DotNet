using System;   
public class ����ó��{
	public static void Main(){
		int intA = 10;
		int intB = 0;        		
		int intC = 0;
		try//���ܸ� �����ϴ� ����
		{
			intC = intA / intB;
		}
		catch(Exception e)//���ܰ� �߻����� �� �����ϴ� ����
		{
			Console.WriteLine("���ܰ� �߻��߽��ϴ�.");	
			Console.WriteLine("���ܳ��� : {0}", e.Message);
		}
		finally//���� ó���� �������� ����Ǵ� ����
		{
			Console.WriteLine("���α׷��� �����մϴ�.");
		}
		Console.WriteLine("{0}", intC);
	}
}
