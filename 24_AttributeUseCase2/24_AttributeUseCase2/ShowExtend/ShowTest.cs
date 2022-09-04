using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_AttributeUseCase2.ShowExtend
{
    [Show(ShowInfo = "I am an attribute on a class")]
    public class ShowTest
    {
        [Show(ShowInfo = "I am an attribute on a method")]
        public void Test()
        {

        }

        [Show(ShowInfo = "I am an attribute on a property")]
        public string TestProperty { get; set; }

        [Show(ShowInfo = "I am an attribute on a field")]
        public string TestField;
    }
}
