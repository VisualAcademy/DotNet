using System;
using System.Collections;

public class 큐
{
	public static void Main()
	{
		//[1] 큐 인스턴스 생성
		Queue queue = new Queue();

		//[2] 큐에 데이터 입력
		Console.WriteLine("Enqueue : VC++");
		queue.Enqueue("VC++");
		Console.WriteLine("Enqueue : VB.NET");
		queue.Enqueue("VB.NET");

		//[3] 큐에서 데이터 꺼내기
		Console.WriteLine("Dequeue : {0}", queue.Dequeue());
		Console.WriteLine("Dequeue : {0}", queue.Dequeue());
	}
}
