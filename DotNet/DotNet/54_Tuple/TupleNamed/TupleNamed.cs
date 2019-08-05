using System;

class TupleNamed
{
    static void Main()
    {
        var boy = (Name: "철수", IsStudent: true, OrderPrice: 1_000 );
        Console.WriteLine(
            $"{boy.Name}(초등학생: {boy.IsStudent}) - 주문: {boy.OrderPrice:C0}");
    }
}
