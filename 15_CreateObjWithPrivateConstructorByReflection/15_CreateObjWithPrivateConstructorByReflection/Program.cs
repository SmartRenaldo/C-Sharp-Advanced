using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _15_CreateObjWithPrivateConstructorByReflection
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------create an object with private constructors by reflection---------");

                Assembly assembly = Assembly.LoadFrom("15_CreateObjWithPrivateConstructorByReflection.dll");

                Type type = assembly.GetType("_15_CreateObjWithPrivateConstructorByReflection.DbSQLite");

                DbSQLite dbSQLite = Activator.CreateInstance(type, true) as DbSQLite;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
