using _24_AttributeUseCase2.ShowExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_AttributeUseCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTest showTest = new ShowTest();
            InvokeCenter invokeCenter = new InvokeCenter();
            invokeCenter.InvokeHandler<ShowTest>(showTest);
        }
    }
}
