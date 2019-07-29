using System;

class ToStringFormat
{
    static void Main()
    {
        //[?] 10 -> +10, -10 -> -10, 0 -> 0
        Console.WriteLine(10.ToString("+#;-#;0"));

        Console.WriteLine(string.Format("{0:+#;-#;0}", -10));

        Console.WriteLine($"{10:+#;-#;0}");
    }
}
