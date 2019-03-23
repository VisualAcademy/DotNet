using System;

class TupleNamed
{
    static void Main()
    {
        // NuGet에서 System.ValueTuple 참조
        var nt = (Name: "철수", IsStudent: true, OrderPrice: 1000 );
        Console.WriteLine(
            $"{nt.Name}(초등학생: {nt.IsStudent}) - 주문: {nt.OrderPrice:C0}");
    }
}
