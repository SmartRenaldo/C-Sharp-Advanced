using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _13_CreateObjByReflection
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------create object by reflection---------");

                Assembly assembly;
                assembly = Assembly.LoadFrom("13_CreateObjByReflection.dll");

                Type type = assembly.GetType("_13_CreateObjByReflection.DbSQLite");
                DbSQLite dbSQLite = Activator.CreateInstance(type) as DbSQLite;

                dbSQLite.Query();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
