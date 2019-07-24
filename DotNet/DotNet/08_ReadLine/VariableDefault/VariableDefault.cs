using System;

class VariableDefault
{
    static void Main()
    {
        int i = default;
        double d = default;
        char c = default;
        string s = default;
        Console.WriteLine($"[{i}], [{d}], [{c}], [{s}]");
        Console.WriteLine($"[{i}], [{d}], [{c == Char.MinValue}], [{s == null}]");
    }
}
