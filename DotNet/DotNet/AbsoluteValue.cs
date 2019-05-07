class AbsoluteValue
{
    static void Main()
    {
        int num = -21;
        int abs = (num < 0) ? -num : num; // 3항 연산자로 음수만 부호 변환
        System.Console.WriteLine("{0}의 절댓값: {1}", num, abs);
    }
}
