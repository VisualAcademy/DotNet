class BreakFor
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i >= 0)
            {
                break; // 현재 코드를 만나면 현재 for 문을 종료함
            }
        } // end of for
    }
}
