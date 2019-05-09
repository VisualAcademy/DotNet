using System;

interface IDog
{
    void Eat();
}

interface ICat
{
    void Eat();
}

class Pet : IDog, ICat
{
    void IDog.Eat() => Console.WriteLine("Dog Eat"); // [1] 명시적으로 IDog 지정

    void ICat.Eat() => Console.WriteLine("Cat Eat"); // [2] 명시적으로 ICat 지정
}

class InterfaceExplicit
{
    static void Main()
    {
        Pet pet = new Pet();
        ((IDog)pet).Eat(); // [A] pet 개체를 IDog 형식으로 형식 변환
        ((ICat)pet).Eat(); // [B] pet 개체를 ICat 형식으로 형식 변환

        IDog dog = new Pet();
        dog.Eat();
        ICat cat = new Pet();
        cat.Eat();
    }
}
