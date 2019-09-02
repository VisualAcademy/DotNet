using System;

namespace 제네릭메서드
{
    class 제네릭메서드
    {
        // 제네릭메서드 : 형식 매개변수 T를 사용, 여러개의 매개변수 동시 처리
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; a = b; b = temp;
        }

        static void Main(string[] args)
        {
            //[1] Input
            string[] data = { "a", "z", "c", "b", "f" };
            Console.WriteLine("정렬 전:");
            PrintData(data);
            //[2] Process : SORT
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (String.Compare(data[i], data[j]) > 0)
                    {
                        //Swap<int>(ref data[i], ref data[j]); 
                        Swap<string>(ref data[i], ref data[j]);
                    }
                }
            }
            //[3] Output
            Console.WriteLine("정렬 후:");
            PrintData(data);
        }

        private static void PrintData(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
        }
    }
}
