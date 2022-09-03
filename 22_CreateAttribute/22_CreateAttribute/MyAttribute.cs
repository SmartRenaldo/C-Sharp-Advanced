using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CreateAttribute
{
    public class MyAttribute : Attribute
    {
        public MyAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
