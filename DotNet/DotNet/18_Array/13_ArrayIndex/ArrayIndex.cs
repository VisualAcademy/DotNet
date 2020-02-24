using System;

class ArrayIndex
{
    static void Main()
    {
        // array 이름으로 1차원 배열 선언과 동시에 1, 2, 3으로 값 초기화
        int[] array = { 1, 2, 3 };
        int index = 0; // 배열의 인덱스는 0부터 시작하기에 0으로 index 변수 초기화

        Console.WriteLine(array[index++]); // array[0] 출력 후, index == 1로 증가 
        Console.WriteLine(array[index++]); // array[1] 출력 후, index == 2로 증가 
        Console.WriteLine(array[index++]); // array[2] 출력 후, index == 3로 증가 

        Console.WriteLine(array[--index]); // index == 2로 감소 후, array[2] 출력 
        Console.WriteLine(array[--index]); // index == 1로 감소 후, array[1] 출력 
        Console.WriteLine(array[--index]); // index == 0로 감소 후, array[0] 출력 
    }
}
