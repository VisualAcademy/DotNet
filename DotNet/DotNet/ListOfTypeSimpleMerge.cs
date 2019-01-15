using System;
using System.Collections.Generic;

namespace DotNet.ListOfTypeSimpleMerge
{
    public class ListOfTypeSimpleMerge
    {
        static void Main()
        {
            List<MergeModel> models = new List<MergeModel>();

            // 샘플 값 저장
            for (int i = 0; i < 21; i++)
            {
                int year = i + DateTime.Now.Year; 
                models.Add(new MergeModel { Year = year, First = 10, Second = 20, Sum = 0 });
            }

            // 따로 계산만 구현
            for (int i = 0; i < models.Count; i++)
            {
                models[i].Sum = models[i].First + models[i].Second; 
            }

            // 출력
            Console.WriteLine("년도\tFirst\tSecond\tSum");
            foreach (var model in models)
            {
                Console.WriteLine($"{model.Year}\t{model.First}\t{model.Second}\t{model.Sum}");
            }
        }
    }

    public class MergeModel
    {
        public int Year { get; set; }
        public double First { get; set; }
        public double Second { get; set; }
        public double Sum { get; set; }
    }
}
