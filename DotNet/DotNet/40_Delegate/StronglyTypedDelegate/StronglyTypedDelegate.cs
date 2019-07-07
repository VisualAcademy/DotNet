using System;

class StronglyTypedDelegate
{
    // 강력한 형식의 대리자 
    public delegate double DelegateType(double x, double y);

    static void Main()
    {
        DelegateType pow = Math.Pow;

        double actual = pow(2, 10);

        Console.WriteLine(actual);
    }
}
