//[?] 속성 만들고 사용하기 
using System;

class Developer
{
    public string Name { get; set; }
}

class Property
{
    static void Main()
    {
        //[1] 클래스의 인스턴스 새성
        Developer developer = new Developer();

        //[2] 속성에 값 설정(set)
        developer.Name = "박용준";

        //[3] 속성의 값 조회(get)
        Console.WriteLine(developer.Name);
    }
}
