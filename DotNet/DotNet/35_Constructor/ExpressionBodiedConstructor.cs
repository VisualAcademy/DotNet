using System;

namespace ExpressionBodiedConstructor
{
    class Pet
    {
        public string Name { get; set; }

        // Expression Bodied Constructor
        public Pet(string name) => Name = name;
    }

    class ExpressionBodiedConstructor
    {
        static void Main()
        {
            Pet pet = new Pet("야옹이");
            Console.WriteLine(pet.Name);
        }
    }
}