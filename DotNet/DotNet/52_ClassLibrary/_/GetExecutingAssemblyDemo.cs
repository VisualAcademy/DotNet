using System;
using System.Reflection;

namespace GetExecutingAssemblyDemo
{
    class GetExecutingAssemblyDemo
    {
        static void Main(string[] args)
        {
            var t = Assembly.GetExecutingAssembly().GetTypes();
            Console.WriteLine($"전체 형식 개수: {t.Length}");
        }
    }
}
