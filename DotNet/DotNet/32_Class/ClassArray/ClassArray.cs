// 특정 클래스 형식의 배열을 선언 후 각 배열의 인스턴스 생성 후 사용
using System;

public class CategoryClass
{
    public void Print(int i) => Console.WriteLine($"카테고리 {i}");
}

class ClassArray
{
    static void Main()
    {
        //[1] 클래스 배열 생성
        CategoryClass[] categories = new CategoryClass[3];

        //[2] 각각의 요소에 인스턴스 생성
        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
