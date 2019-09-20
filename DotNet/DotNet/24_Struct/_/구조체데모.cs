using System;

//[!] 구조체 선언
public struct BusinessCard
{
    public string Name;     // 이름
    public int Age;         // 나이
}

public class 구조체데모
{
    //[!] 출력 전담 함수(메서드)
    public static void Print(object name, object age)
    {
        Console.WriteLine("{0}은/는 {1}살입니다.", name, age);
    }

    public static void Main()
    {
        #region 변수와 배열
        //[1] 변수(Variable) : 하나의 이름으로 하나의 데이터형식을 하나만 보관
        string name = "홍길동";
        int age = 21;
        Print(name, age);
        //[2] 배열(Array) : 하나의 이름으로 하나의 데이터 형식을 하나 이상 보관
        object[] address = new object[2];
        address[0] = "백두산";
        address[1] = 100;
        Print(address[0], address[1]);
        #endregion
        //[3] 구조체 변수: 구조체 형식의 변수 선언
        BusinessCard biz;
        biz.Name = "임꺽정";
        biz.Age = 40;
        Print(biz.Name, biz.Age);
        //[4] 구조체 배열
        BusinessCard[] names = new BusinessCard[2];
        names[0].Name = "한라산"; names[0].Age = 1;
        names[1].Name = "지리산"; names[1].Age = 11;
        for (int i = 0; i < names.Length; i++)
        {
            Print(names[i].Name, names[i].Age);
        }
    }
}
