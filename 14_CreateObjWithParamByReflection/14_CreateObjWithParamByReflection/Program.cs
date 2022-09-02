using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateObjWithParamByReflection
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------create an object with parameters by reflection---------");

                Assembly assembly = Assembly.LoadFrom("14_CreateObjWithParamByReflection.dll");

                Type type = assembly.GetType("_14_CreateObjWithParamByReflection.DbSQLite");
                
                foreach(ConstructorInfo constructor in type.GetConstructors())
                {
                    Console.WriteLine(constructor.Name);

                    foreach (var param in constructor.GetParameters())
                    {
                        Console.WriteLine(param.ParameterType);
                    }
                }

                DbSQLite dbSQLite = Activator.CreateInstance(type) as DbSQLite;
                DbSQLite dbSQLite2 = Activator.CreateInstance(type, new object[] {"select * from students"}) as DbSQLite;
                DbSQLite dbSQLite3 = Activator.CreateInstance(type, new object[] {25}) as DbSQLite;
                DbSQLite dbSQLite4 = Activator.CreateInstance(type, new object[] {"select * from students", 25}) as DbSQLite;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
