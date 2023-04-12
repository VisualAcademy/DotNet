using System;

namespace DoublyLinkedList
{
    public class Node
    {
        public Node PrevNode;   // 역방향 포인터
        public string Name;      // 이름
        public string Phone;     // 전화번호
        public Node NextNode;    // 정방향 포인터
    }

    class Program
    {
        static Node GetNode()
        {
            return new Node();
        }

        static void Main(string[] args)
        {
            Node head, tail, current;

            // 역방향 리스트 생성
            tail = null;

            current = GetNode();
            current.Name = "aa";
            current.Phone = "11";

            current.PrevNode = tail;
            tail = current;

            current = GetNode();
            current.Name = "bb";
            current.Phone = "22";

            current.PrevNode = tail;
            tail = current;

            current = GetNode();
            current.Name = "cc";
            current.Phone = "33";

            current.PrevNode = tail;
            tail = current;

            // 정방향 리스트 생성
            current = tail;
            head = null;

            current.NextNode = head;
            head = current;
            current = current.PrevNode;

            current.NextNode = head;
            head = current;
            current = current.PrevNode;

            current.NextNode = head;
            head = current;
            current = current.PrevNode;

            // 정방향 리스트 출력
            current = head;

            Console.WriteLine($"{current.Name} {current.Phone}");
            current = current.NextNode;

            Console.WriteLine($"{current.Name} {current.Phone}");
            current = current.NextNode;

            Console.WriteLine($"{current.Name} {current.Phone}");
            current = current.NextNode;

            // 역방향 리스트 출력
            current = tail;

            Console.WriteLine($"{current.Name} {current.Phone}");
            current = current.PrevNode;

            Console.WriteLine($"{current.Name} {current.Phone}");
            current = current.PrevNode;

            Console.WriteLine($"{current.Name} {current.Phone}");
            current = current.PrevNode;
        }
    }
}
