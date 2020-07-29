using System;

namespace MyExtensions
{
    static class StringExtension
    {
        public static string Ten(this string msg) => msg.Substring(0, 10);
        public static string Five(this string msg) => msg.Substring(0, 5);
        public static string AddElipsis(this string msg) => msg + "...";
        public static string AddElipsis(this string msg, string elipsis) 
            => $"{msg}{elipsis}";
    }

    class MyExtensionsDemo
    {
        static void Main()
        {
            string message = "안녕하세요. 반갑습니다. 또 만나요.";
            Console.WriteLine(message.Ten().Five().AddElipsis());
            Console.WriteLine(message.Ten().Five().Five().AddElipsis("___"));
        }
    }
}
