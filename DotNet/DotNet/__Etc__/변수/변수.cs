//[?] 변수(Variable): 프로그램에서 사용할 데이터를 저장해 놓는 그릇
using System;

class 변수
{
    static void Main()
    {
        //[1] 변수 만들기(선언)
        int i; // i 이름으로 변수 만들기

        //[2] 변수에 값을 저장하기(대입, 할당)
        i = 1234;

        //[3] 변수에 들어 있는 값 사용하기(참조)
        Console.WriteLine(i); // 1234
    }
}
