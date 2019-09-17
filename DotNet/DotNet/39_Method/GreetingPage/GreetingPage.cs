using System;

class Greeting
{
    private string message = "사이트에 오신 걸 환영합니다.";
    public void Say() => Console.WriteLine(this.message);
}

class GreetingPage
{
    static void Main() => (new Greeting()).Say(); 
}
