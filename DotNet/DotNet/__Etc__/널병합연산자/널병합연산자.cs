class 널병합연산자
{
    static void Main()
    {
        string value, message;

        //[1] if 구문으로 null 값 비교
        value = "[1] 값이 있습니다.";
        if (value != null)
        {
            message = value;
        }
        else
        {
            message = "값이 없습니다.";
        }

        System.Console.WriteLine(message);

        //[2] ?? 연산자로 null 값 비교
        value = null;
        message = value ?? "[2] 값이 없습니다.";

        System.Console.WriteLine(message);
    }
}
