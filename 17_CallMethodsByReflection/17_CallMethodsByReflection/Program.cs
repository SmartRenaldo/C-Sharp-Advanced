using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17_CallMethodsByReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Method Reflection-------------");

            Assembly assembly = Assembly.LoadFrom("17_CallMethodsByReflection.dll");
            Type type = assembly.GetType("_17_CallMethodsByReflection.Student");
            Student student = Activator.CreateInstance(type) as Student;

            foreach (var method in type.GetMethods())
            {
                Console.WriteLine(method.Name);

                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine(parameter.Name + " " + parameter.ParameterType);
                }
            }

            {
                MethodInfo methodInfo1 = type.GetMethod("Method1");
                methodInfo1.Invoke(student, null);
            }

            {
                MethodInfo methodInfo2 = type.GetMethod("Method2", new Type[] { });
                methodInfo2.Invoke(student, null);
            }

            {
                MethodInfo methodInfo2 = type.GetMethod("Method2", new Type[] { typeof(string) });
                methodInfo2.Invoke(student, new object[] { "Shannon" });
            }

            {
                MethodInfo methodInfo2 = type.GetMethod("Method2", new Type[] { typeof(string), typeof(int) });
                methodInfo2.Invoke(student, new object[] { "Shannon", 55 });
            }

            {
                MethodInfo methodInfo3 = type.GetMethod("Method3", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { });
                methodInfo3.Invoke(student, null);
            }

            {
                MethodInfo methodInfo3 = type.GetMethod("Method3", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { typeof(int) });
                methodInfo3.Invoke(student, new object[] { 55 });
            }

            {
                MethodInfo methodInfo3 = type.GetMethod("Method3", BindingFlags.Static | BindingFlags.Public, new Type[] { typeof(string) });
                methodInfo3.Invoke(null, new object[] { "Shannon" });
            }
        }
    }
}
