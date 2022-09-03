using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _23_AttributeUseCase1
{
    public class AttributeInvoke
    {
        public string GetRemark(CoffeeState coffeeState)
        {
            Type type = coffeeState.GetType();
            var field = type.GetField(coffeeState.ToString());

            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                RemarkAttribute attr = (RemarkAttribute)field.GetCustomAttribute(typeof(RemarkAttribute));

                return attr.Remark;
            }
            else
            {
                return coffeeState.ToString();
            }
        }
    }
}
