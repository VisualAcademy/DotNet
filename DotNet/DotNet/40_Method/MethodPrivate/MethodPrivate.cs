using System;

class Dog
{
    public void Eat()
    {
        Console.WriteLine("[1] 밥을 먹는다.");
        this.Digest(); // [2] private 메서드 호출
    }

    private void Digest()
    {
        Console.WriteLine("[2] 소화를 시킨다.");
    }
}

class MethodPrivate
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat(); // [1] public 메서드 호출 
    }
}
