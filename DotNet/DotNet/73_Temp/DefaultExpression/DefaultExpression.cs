using System;
using System.Text;

class DefaultExpression
{
    static void Main()
    {
        // default 키워드
        int intDefault = default(int); // int 형식의 기본값
        bool boolDefault = default(bool); // bool 형식의 기본값
        string strDefault = default(string); // string 형식의 기본값
        StringBuilder sbDefault =
            default(StringBuilder); // StringBuilder 클래스의 기본값

        Console.WriteLine(intDefault); // 0
        Console.WriteLine(boolDefault); // false
        Console.WriteLine(strDefault); // null
        Console.WriteLine(sbDefault); // null
        Console.WriteLine(sbDefault == null); // true
    }
}
