using System.Reflection;

namespace _12_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------reflection---------");

                // method 1 for loading
                // Assembly assembly = Assembly.Load("12_Reflection");

                // method 2 for loading
                // Assembly assembly = Assembly.LoadFile("C:\\Projects\\C# Advanced\\12_Reflection\\12_Reflection\\bin\\Debug\\net6.0\\12_Reflection.dll");

                // method 3 for loading
                // Assembly assembly = Assembly.LoadFrom("12_Reflection.dll");
                Assembly assembly = Assembly.LoadFrom("C:\\Projects\\C# Advanced\\12_Reflection\\12_Reflection\\bin\\Debug\\net6.0\\12_Reflection.dll");

                foreach (var type in assembly.GetTypes())
                {
                    Console.WriteLine(type.Name);

                    foreach (var field in type.GetFields())
                    {
                        Console.WriteLine("field name: " + field.Name);
                    }

                    foreach (var method in type.GetMethods())
                    {
                        Console.WriteLine("method name: " + method.Name);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
