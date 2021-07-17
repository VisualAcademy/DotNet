/*
큐(Queue) : FIFO(First In First Out) 형태의 데이터 저장
- Enqueue() : 큐에 데이터 입력
- Dequeue() : 큐에서 데이터 출력
*/
using System;
using System.Collections;

public class 큐설명
{
    static void Main(string[] args)
    {
        // 큐 생성
        Queue q = new Queue();
        // 큐에 데이터 입력 : Enqueue()
        q.Enqueue("C언어");
        q.Enqueue("C++");
        q.Enqueue("C#");
        // 큐에서 데이터 출력 : Dequeue()
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(q.Dequeue());
        }
    }
}