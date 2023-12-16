using System;

class SelectionSortFunction
{
    static void Main()
    {
        // 사용자로부터 입력 받기
        string input = Console.ReadLine();
        // 입력 받은 문자열을 정수 배열로 변환
        int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

        // 선택 정렬로 배열 정렬하기
        SelectionSort(numbers);

        // 정렬된 배열 출력하기
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }

        // 줄바꿈으로 출력 끝내기
        Console.WriteLine();
    }

    static void SelectionSort(int[] numbers)
    {
        // 배열의 길이 저장하기
        int n = numbers.Length;
        // 요소들을 교환할 때 사용할 임시 변수
        int temp;

        // 선택 정렬 알고리즘 수행
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // numbers[i]가 numbers[j]보다 작으면 두 값을 교환
                if (numbers[i] < numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
    }
}
