//[?] Queue: FIFO(First In First Out) 형태의 데이터 보관: 대기행렬(은행 줄서기)
// Enqueue(): 큐에 데이터 저장(QueueIn)
// Dequeue(): 큐에서 데이터 출력(QueueOut)
using System;
using System.Collections;

class QueueDemo
{
    static void Main()
    {
        //[1] Queue 클래스의 인스턴스 생성
        var queue = new Queue();

        //[2] 큐(대기행렬)에 데이터 입력: Enqueue()
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3] 큐에서 데이터 출력: Dequeue()
        Console.WriteLine(queue.Dequeue()); // 10
        Console.WriteLine(queue.Dequeue()); // 20
        Console.WriteLine(queue.Dequeue()); // 30
    }
}
