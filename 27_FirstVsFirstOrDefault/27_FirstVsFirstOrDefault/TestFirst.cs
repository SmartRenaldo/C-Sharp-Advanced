using _27_FirstVsFirstOrDefault;
using System;
using System.Collections.Generic;
using System.Linq;
class TestFirst : IFirst
{
    public void Show()
    {
        List<double> val = new List<double> { };
        double d = val.AsQueryable().First();
        Console.WriteLine("d = " + d);
        if (d == 0.0D)
        {
            d = 0.1D;
        }
        Console.WriteLine("d changed = " + d);
    }
}