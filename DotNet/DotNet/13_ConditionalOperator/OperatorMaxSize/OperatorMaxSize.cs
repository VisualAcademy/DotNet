//[?] 들어오는 값이 20 이상이면 20으로 초기화, 20 미만이면 해당 값으로 초기화
using System;

class OperatorMaxSize
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
