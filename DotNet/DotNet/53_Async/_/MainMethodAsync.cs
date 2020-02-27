using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

class MainMethodAsync
{
    /// <summary>
    /// C# 7.3 이후로는 Main 메서드에도 async 키워드를 붙일 수 있음
    /// async와 await는 쌍으로 함께 사용됨
    /// </summary>
    /// <returns></returns>
    static async Task Main()
    {
        int r = await GetDataAsync();
        WriteLine(r);

        // 0b 접두사를 붙이고 이진수를 4자리 단위로 표시 가능
        int[] numbers = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };
        int result = await SumOfSquaresAsync(numbers);
        WriteLine(result);
    }

    static async Task<int> GetDataAsync()
    {
        return await Task.FromResult(1234);
    }

    static async Task<int> SumOfSquaresAsync(int[] numbers, CancellationToken ct = default)
    {
        return await Task.Run(function: Compute, ct);
        int Compute() => numbers.Select(i => i * i).Sum();
    }
}
