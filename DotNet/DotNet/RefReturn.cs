using System;

namespace DotNet
{
    public class RefReturn
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3 };

            Console.WriteLine(numbers[1]); // 2

            RefFunc(numbers, 1) = 1234; // numbers[1] = 1234

            Console.WriteLine(numbers[1]); // 1234

            ref int RefFunc(int[] nums, int position)
            {
                return ref nums[position];
            }
        }
    }
}
