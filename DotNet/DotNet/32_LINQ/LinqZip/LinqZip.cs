// LINQ Zip() 확장 메서드: 관련있는 2개의 시퀀스(컬렉션)를 묶어서 출력
using System;
using System.Linq;

class LinqZip
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 }; 
        string[] words = { "하나", "둘" }; 

        var numbersAndWords = 
            numbers.Zip(words, (first, second) => first + "-" + second);

        foreach (var item in numbersAndWords)
        {
            Console.WriteLine(item); // 1-하나, 2-둘
        }
    }
}
