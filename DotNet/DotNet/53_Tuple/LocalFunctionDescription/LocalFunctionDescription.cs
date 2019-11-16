using static System.Console;

class LocalFunctionDescription
{
    static void Main()
    {
        //[1] numbers = { 1, 2, 4, 8 }
        int[] numbers = { 0b1, 0B10, 0b0100, 0B0000_1000 };
        var (sum, count) = Tally(numbers);
        WriteLine($"Sum: {sum}, Count: {count}");
    }

    static (int, int) Tally(int[] values)
    {
        var r = (Sum: 0, Count: 0);
        foreach (var v in values)
        {
            Add(v, 1);
        }
        return r;

        //[2] 로컬 함수(Local Function): 함수내에서 또 다른 함수 정의
        void Add(int s, int c)
        {
            r.Sum += s; // 합계
            r.Count += c; // 건수
        }
    }
}
