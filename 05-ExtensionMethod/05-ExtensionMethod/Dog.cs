using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExtensionMethod
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public string GetName()
        {
            return Name;
        } 
    }
}
