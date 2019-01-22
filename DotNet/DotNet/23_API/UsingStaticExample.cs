using System;
using System.Linq;
using static System.Math;
using static System.Linq.Enumerable;

public class UsingStaticDemo
{
    public void MathExample(double x, double y)
    {
        var pow1 = Math.Pow(x, y);

        var pow = Pow(x, y);
        var min = Min(x, y);

        var range = Range(5, 50);
        var evens = range.Where(i => i % 2 == 0);
    }
}
