using System;

class VerbatimStringLiterals
{
    static void Main()
    {
        Console.WriteLine("C:\\Users\\VisualAcademy"); // "C:\\Users\\VisualAcademy" - C:\Users\VisualAcademy
        Console.WriteLine(@"C:\Users\VisualAcademy"); // "C:\\Users\\VisualAcademy" - C:\Users\VisualAcademy
        Console.WriteLine(@""""); // "\"" - "
        Console.WriteLine(@"""VisualAcademy"""); // "\"VisualAcademy\"" - "VisualAcademy"
    }
}
