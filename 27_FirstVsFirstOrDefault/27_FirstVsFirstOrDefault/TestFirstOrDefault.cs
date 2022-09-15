using _27_FirstVsFirstOrDefault;
using System;
using System.Collections.Generic;
using System.Linq;
class TestFirstOrDefault : IFirst
{
    public void Show()
    {
        List<double> val = new List<double> { };
        double d = val.AsQueryable().FirstOrDefault();
        Console.WriteLine("Default Value = " + d);
        if (d == 0.0D)
        {
            d = 0.1D;
        }
        Console.WriteLine("Default Value changed = " + d);
    }
}