using static System.Console;

class StringIsNullOrEmptyDemo
{
    static void Main()
    {
        var str = "";
        //[1] null 비교와 "" 값 비교를 사용하여 처리
        if (str == null || str == "")
        {
            WriteLine($"{nameof(str)} 변수의 값은 null 또는 빈(Empty)값입니다.");
        }
        //[2] String.IsNullOrEmpty() 메서드를 사용하여 처리
        if (string.IsNullOrEmpty(str))
        {
            WriteLine($"{nameof(str)} 변수의 값은 null 또는 빈(Empty)값입니다.");
        }
    }
}
