using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractMethod
{
    public class AbstractMethodChild : AbstractMethod
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }

        public override int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
