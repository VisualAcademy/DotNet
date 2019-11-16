//[?] dynamic 키워드로 선언된 변수는 런타임 시점에 데이터 형식이 결정된다. 
using System; 

class DynamicallyTypedObjects
{
    static void Main()
    {
        dynamic x = 1; // 컴파일 시 dynamic, 런타임 시 System.Int32
        dynamic y = "Hello"; // 컴파일 시점에는 dynamic, 런타임 시점에는 System.String 

        Console.WriteLine($"x: {x}, {x.GetType()}"); 
        Console.WriteLine($"y: {y}, {y.GetType()}");
    }
}
