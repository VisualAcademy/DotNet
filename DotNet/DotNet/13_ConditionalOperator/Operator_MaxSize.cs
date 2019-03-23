using System;

class Operator_MaxSize
{
    static void Main()
    {
        const int maxSize = 20; // 최댓값을 20으로 정함
        int pageSize = 0;

        pageSize = 10;
        pageSize = (pageSize > maxSize) ? maxSize : pageSize; // 10
        Console.WriteLine(pageSize); // 10

        pageSize = 50;
        pageSize = (pageSize > maxSize) ? maxSize : pageSize; // 20
        Console.WriteLine(pageSize); // 20
    }
}
