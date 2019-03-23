using System;

namespace PetDemo
{
    /// <summary>
    /// 애완동물
    /// </summary>
    class Pet
    {
        /// <summary>
        /// 몸무게
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 먹이를 주면 몸무게 증가 
        /// </summary>
        /// <param name="weight">몸무게</param>
        public void Feed(int weight)
        {
            Weight += weight;
        }
    }

    class PetDemo
    {
        static void Main()
        {
            Pet pet = new Pet();
            pet.Weight = 50; // 속성으로 값 초기화
            pet.Feed(10); // 메서드로 값 증가 
            Console.WriteLine(pet.Weight); // 60
        }
    }
}
