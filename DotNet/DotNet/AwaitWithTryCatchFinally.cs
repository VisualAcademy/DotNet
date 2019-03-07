using System;
using System.Threading.Tasks;

class AwaitWithTryCatchFinally
{
    static async Task Main()
    {
        await DoAsync();
    }

    static async Task DoAsync()
    {
        try
        {
            await Task.Delay(1);
        }
        catch (Exception)
        {
            await Task.Delay(1);
        }
        finally
        {
            await Task.Delay(1);
        }
    }
}
