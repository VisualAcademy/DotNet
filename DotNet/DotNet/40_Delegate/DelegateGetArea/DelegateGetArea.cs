using System;

class DelegateGetArea
{
    static double GetArea(int r) => 3.14 * r * r;

    delegate double GetAreaPointer(int r);

    static void Main()
    {
        GetAreaPointer pointer = GetArea;
        Console.WriteLine(pointer.Invoke(10));
        Console.WriteLine(pointer(10));
    }
}
