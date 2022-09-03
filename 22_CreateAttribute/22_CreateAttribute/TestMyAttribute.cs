using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CreateAttribute
{
    public class TestMyAttribute
    {
        public void Test()
        {
            Type type = typeof(UseMyAttribute);
            object[] costomAttribute = type.GetCustomAttributes(true);

            foreach (object item in costomAttribute)
            {
                MyAttribute myAttribute = item as MyAttribute;

                if (myAttribute != null)
                {
                    Console.WriteLine(myAttribute.Name);
                }
            }
        }
    }
}
