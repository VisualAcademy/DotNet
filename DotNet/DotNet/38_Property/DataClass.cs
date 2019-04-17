//[?] 데이터 클래스(레코드 클래스, 레코드 형식, 모델 클래스): 자동 속성을 사용하여 구현
using System;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

class DataClass
{
    static void Main()
    {
        // 개체 리터럴을 사용하여 개체 초기화 
        var customer = new Customer { Id = 1, Name = "박용준", City = "인천" };
        Console.WriteLine($"{customer.Id}, {customer.Name}, {customer.City}");
    }
}
