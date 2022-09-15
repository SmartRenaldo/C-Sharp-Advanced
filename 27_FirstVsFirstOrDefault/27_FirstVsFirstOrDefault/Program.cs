using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_FirstVsFirstOrDefault
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IFirst test = new TestFirst();
            IFirst test = new TestFirstOrDefault();
            test.Show();
        }
    }
}
