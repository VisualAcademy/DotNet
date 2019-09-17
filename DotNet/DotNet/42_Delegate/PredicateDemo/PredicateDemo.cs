using System;

public class PredicateDemo
{
    static void Main()
    {
        Predicate<string> isNullOrEmpty = String.IsNullOrEmpty;

        Console.WriteLine(isNullOrEmpty("Not Null"));

        Predicate<Type> isPrimitive = t => t.IsPrimitive;

        Console.WriteLine(isPrimitive(typeof(int)));
    }
}
