using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3.ValidateExtend
{
    public static class AttributeExtend
    {
        public static bool Validate<T>(this T t)
        {
            Type type = t.GetType();

            foreach (var property in type.GetProperties())
            {
                if (property.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object value = property.GetValue(t);

                    foreach (AbstractValidateAttribute attribute in 
                        property.GetCustomAttributes(typeof(AbstractValidateAttribute), true))
                    {
                        if (!attribute.Validate(value))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
