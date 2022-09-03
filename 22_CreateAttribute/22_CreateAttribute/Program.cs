using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CreateAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMyAttribute myAttribute = new TestMyAttribute();
            myAttribute.Test();
        }
    }
}
