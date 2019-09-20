// null: 아무런 가치가 없음. 참조형 변수에 아무런 값을 설정하지 않음.
using static System.Console;

class NullDemo
{
    static void Main()
    {
        int i = 0;              // 값형(Value Type)
        string s = null;        // 참조형(Reference Type)
        s = "안녕하세요.";
        string empty = "";      // 빈값(Empty)은 null과는 다름

        WriteLine(i);           // 0
        WriteLine(s);           // null -> "안녕하세요."
        WriteLine(empty);       // ""
    }
}
