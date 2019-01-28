using System;

namespace 문자열분리
{
    class 문자열분리
    {
        static void Main(string[] args)
        {
            string src = "홍길동,114,2007-12-12,1234";

            string[] records = src.Split(',');

            Console.WriteLine(records[3]);

            for (int i = 0; i < records.Length; i++)
            {
                Console.WriteLine(records[i]);
            }
            Console.WriteLine();


            foreach (var record in records)
            {
                Console.WriteLine(record);
            }
        }
    }
}
