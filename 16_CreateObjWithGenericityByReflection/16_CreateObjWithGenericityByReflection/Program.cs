using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _16_CreateObjWithGenericityByReflection
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------create an object with private constructors by reflection---------");

                Assembly assembly = Assembly.LoadFrom("16_CreateObjWithGenericityByReflection.dll");

                // `3 means there are 3 genericity types
                Type type = assembly.GetType("_16_CreateObjWithGenericityByReflection.DbSQLite`3");
                Type genericityType = type.MakeGenericType(new Type[] { typeof(int), typeof(double), typeof(bool) });

                DbSQLite<int, double, bool> dbSQLite = Activator.CreateInstance(genericityType) as DbSQLite<int, double, bool>;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
