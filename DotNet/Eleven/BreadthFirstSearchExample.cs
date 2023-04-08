namespace BreadthFirstSearchExample
{
    using System;
    using System.Collections.Generic;

    class Graph
    {
        private int numVertices; // 정점의 개수
        private List<int>[] adjList; // 인접 리스트를 사용한 그래프 표현

        // 생성자: 정점의 개수를 인자로 받아 초기화
        public Graph(int numVertices)
        {
            this.numVertices = numVertices;
            adjList = new List<int>[numVertices];
            for (int i = 0; i < numVertices; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        // 간선 추가 메서드: 두 정점 u, v를 인자로 받아 간선을 추가
        public void AddEdge(int u, int v)
        {
            adjList[u].Add(v);
        }

        // 너비 우선 탐색 메서드: 시작 정점을 인자로 받아 실행
        public void BFS(int startVertex)
        {
            bool[] visited = new bool[numVertices]; // 방문한 정점을 기록하는 배열
            Queue<int> queue = new Queue<int>(); // 탐색할 정점을 저장하는 큐

            visited[startVertex] = true; // 시작 정점을 방문한 것으로 표시
            queue.Enqueue(startVertex); // 시작 정점을 큐에 삽입

            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue(); // 큐에서 정점을 꺼냄
                Console.WriteLine("방문한 노드: " + currentVertex);

                // 인접한 정점들을 순회하며 방문하지 않은 정점을 큐에 삽입
                foreach (int adjacent in adjList[currentVertex])
                {
                    if (!visited[adjacent])
                    {
                        visited[adjacent] = true;
                        queue.Enqueue(adjacent);
                    }
                }
            }
        }
    }

    class BreadthFirstSearchExample
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(6); // 6개의 정점을 가진 그래프 객체 생성

            // 간선 추가
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 4);
            graph.AddEdge(2, 5);

            graph.BFS(0); // 시작 정점을 0으로 설정하고 너비 우선 탐색 실행
        }
    }
}
