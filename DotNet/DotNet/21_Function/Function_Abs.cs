class Function_Abs
{
    static void Main()
    {
        int num = -21;
        int abs = Abs(num);
        System.Console.WriteLine("{0}의 절댓값: {1}", num, abs);
    }
    // 절댓값을 구하는 함수 만들기
    static int Abs(int num)
    {
        return (num < 0) ? -num : num;
    }
}
