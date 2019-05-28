// 제네릭 리스트: 배열과 제네릭 리스트
using System.Collections.Generic;

class ListOfInt
{
    static void Main()
    {
        // 배열 사용
        int[] arrNumbers = new int[2];
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            System.Console.WriteLine(arrNumbers[i]); // 10, 20
        }

        // 제네릭 리스트 사용: List<T>
        List<int> lstNumbers = new List<int>();
        lstNumbers.Add(30);
        lstNumbers.Add(40);
        for (int i = 0; i < lstNumbers.Count; i++)
        {
            System.Console.WriteLine(lstNumbers[i]); // 30, 40
        }
    }
}
