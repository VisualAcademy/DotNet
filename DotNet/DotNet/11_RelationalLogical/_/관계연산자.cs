using System;

class Program
{
    static void Main(string[] args)
    {
        int first_num = 3, second_num = 5, greater, smaller;
        greater = first_num > second_num ? 1 : 0;
        smaller = first_num < second_num ? 1 : 0;
        Console.WriteLine("first_num = {0} second_num = {1} " +
                          "first_num > second_num = {2} " +
                          "first_num < second_num = {3}",
                          first_num, second_num, greater, smaller);
    }
}
