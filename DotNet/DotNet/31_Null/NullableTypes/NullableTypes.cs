using System;

class NullableTypes
{
    static void Main()
    {
        bool? unknown = null;
        if (unknown ?? true)
            Console.WriteLine("출력됨");

        unknown = false;
        if (!unknown ?? false)
            Console.WriteLine("출력됨");
    }
}
