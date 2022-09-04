using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _24_AttributeUseCase2.ShowExtend
{
    public class InvokeCenter
    {
        public void InvokeHandler<T>(T show) where T:new()
        {
            Type type = show.GetType();

            if (type.IsDefined(typeof(ShowAttribute), true))
            {
                object[] attributes = type.GetCustomAttributes(typeof(ShowAttribute), true);

                foreach (ShowAttribute attribute in attributes)
                {
                    attribute.Show();
                }

                foreach (MethodInfo method in type.GetMethods())
                {
                    if (method.IsDefined(typeof(ShowAttribute), true))
                    {
                        object[] attributeMethods = method.GetCustomAttributes(typeof(ShowAttribute), true);

                        foreach (ShowAttribute attribute in attributeMethods)
                        {
                            attribute.Show();
                        }
                    }
                }

                foreach (PropertyInfo property in type.GetProperties())
                {
                    if (property.IsDefined(typeof(ShowAttribute), true))
                    {
                        object[] attributeProperties = property.GetCustomAttributes(typeof(ShowAttribute), true);

                        foreach (ShowAttribute propertyAttribute in attributeProperties)
                        {
                            propertyAttribute.Show();
                        }
                    }
                }

                foreach (FieldInfo field in type.GetFields())
                {
                    if (field.IsDefined(typeof(ShowAttribute), true))
                    {
                        object[] attributeFields = field.GetCustomAttributes(typeof(ShowAttribute), true);

                        foreach (ShowAttribute fieldAttribute in attributeFields)
                        {
                            fieldAttribute.Show();
                        }
                    }
                }
            }
        }
    }
}
