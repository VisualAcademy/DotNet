using System;

class Catalog
{
    //[1] 정수형 인덱서: this[int index] 형태로 정의되어 개체명[0], 개체명[1] 형태로 호출됨 
    public string this[int index]
    {
        get
        {
            return (index % 2 == 0) ? $"{index}: 짝수 반환" : $"{index}: 홀수 반환";
        }
    }
}

class IndexerNote
{
    static void Main()
    {
        Catalog catalog = new Catalog();
        Console.WriteLine(catalog[0]); //[2] 개체명[인덱스] 형태로 호출 가능
        Console.WriteLine(catalog[1]);
        Console.WriteLine(catalog[2]);
    }
}
