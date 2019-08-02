//[?] 이분(이진) 검색(탐색): 반씩 나눠서 검색, 정렬이 되어있어야 함. 
using System;

/// <summary>
/// 검색 알고리즘(Search Algorithm): 주어진 데이터에서 특정 데이터를 찾기 
/// </summary>
class SearchAlgorithm
{
    static void Main()
    {
        //[1] Input: 정수 배열 대신에 List<int> 사용해볼 것: 많이 사용했기에...
        int[] data = { 1, 3, 5, 7, 9 }; //[!] 오름차순 정렬되었다고 가정...
        int N = data.Length; // 의사코드
        int search = 3; // 검색할 데이터: Console.ReadLine() 등으로 표현
        bool flag = false; // 찾았으면 true 그렇지않으면 false 
        int index = -1; // 찾은 위치

        // 이분탐색 관련 변수
        //[2] Process: Binary Search: Full Scan -> Index Scan
        int low = 0; // min: 낮은 인덱스
        int high = N - 1; // max: 높은 인덱스 
        while (low <= high)
        {
            int mid = (low + high) / 2; // // 중간 인덱스 구하기
            if (data[mid] == search)
            {
                flag = true; index = mid; break;
            }
            if (data[mid] < search)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        //[3] Output    
        if (flag)
        {
            Console.WriteLine($"{search}를 {index}위치에서 찾았습니다.");
        }
        else
        {
            Console.WriteLine("찾지 못했습니다.");
        }
    }
}

//int[] data = { 1, 3, 5, 7, 9 };
//if (Array.BinarySearch<int>(data, 3) >= 0)
//{
//    Console.WriteLine($"{3} - {Array.BinarySearch<int>(data, 3)}");
//}
//3 - 1

//var result = data.ToList().BinarySearch(3);
//result
//1
