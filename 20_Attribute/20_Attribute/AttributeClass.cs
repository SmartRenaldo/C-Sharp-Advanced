using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Attribute
{
    public class AttributeClass
    {
        [DebuggerStepThrough]
        public void HandleMethod()
        {
            Console.WriteLine("Simple method");
        }
    }
}
