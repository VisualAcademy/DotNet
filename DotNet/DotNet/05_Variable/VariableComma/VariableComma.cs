//[?] 콤마를 사용하여 동일 데이터 형식을 갖는 변수 여러 개 만들기
using System;

class VariableComma
{
    static void Main()
    {
        //[1] 콤마(,) 기호로 여러 개의 변수 선언
        int number1, number2, number3;

        number1 = 1;
        number2 = 2;
        number3 = 3;

        Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
    }
}
