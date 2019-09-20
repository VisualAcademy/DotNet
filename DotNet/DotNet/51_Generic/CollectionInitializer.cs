//[?] 컬렉션 이니셜라이저(C# 3.0 특징)
using System;
using System.Collections.Generic;

class Choice
{
    public int Id { get; set; }
    public string ChoiceText { get; set; }
    public bool IsAnswer { get; set; }
}

class CollectionInitializer
{
    static void Main()
    {
        List<Choice> choices = new List<Choice>() {
            new Choice() { Id = 1, ChoiceText = "1", IsAnswer = false },
            new Choice() { Id = 2, ChoiceText = "2", IsAnswer = true },
            new Choice() { Id = 3, ChoiceText = "3", IsAnswer = false }
        };
        Console.WriteLine("(문제) 1 + 1은?");
        foreach (var c in choices)
        {
            Console.WriteLine($"{c.Id}: {c.ChoiceText} ({c.IsAnswer})");
        }
    }
}
