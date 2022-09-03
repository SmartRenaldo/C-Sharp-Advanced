using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _18_CallGenericityMethodsByReflection
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------create an object with private constructors by reflection---------");

                Assembly assembly = Assembly.LoadFrom("18_CallGenericityMethodsByReflection.dll");

                // `3 means there are 3 genericity types
                Type type = assembly.GetType("_18_CallGenericityMethodsByReflection.DbSQLite`3");
                Type genericityType = type.MakeGenericType(new Type[] { typeof(int), typeof(double), typeof(bool) });
                DbSQLite<int, double, bool> dbSQLite = Activator.CreateInstance(genericityType) as DbSQLite<int, double, bool>;
                MethodInfo methodInfo = genericityType.GetMethod("Delete");
                var methodGeneric = methodInfo.MakeGenericMethod(new Type[] { typeof(int), typeof(double), typeof(bool) });
                methodGeneric.Invoke(dbSQLite, new object[] { 5, 5.5, true });

                Type type2 = assembly.GetType("_18_CallGenericityMethodsByReflection.DbPostgreSQL");
                DbPostgreSQL dbPostgreSQL = Activator.CreateInstance(type2) as DbPostgreSQL;
                MethodInfo methodInfo2 = type2.GetMethod("Delete");
                var methodGeneric2 = methodInfo2.MakeGenericMethod(new Type[] { typeof(DateTime), typeof(string), typeof(bool) });

                methodGeneric2.Invoke(dbPostgreSQL, new object[] { DateTime.Now, "Jenny", true });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
