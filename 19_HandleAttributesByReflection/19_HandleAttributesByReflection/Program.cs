using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _19_HandleAttributesByReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Handle Attributes by Reflection-------------");

            Student s = new Student()
            {
                Id = 1,
                Name = "TARA",
                Address = "Campbelltown",
                age = 17
            };

            Assembly assembly = Assembly.LoadFrom("19_HandleAttributesByReflection.dll");
            Type type = assembly.GetType("_19_HandleAttributesByReflection.Student");
            Student student = Activator.CreateInstance(type) as Student;

            Console.WriteLine("Properties:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} -- {prop.Name} -- {prop.GetValue(s)}");
            }

            foreach (var prop in type.GetProperties())
            {
                if (prop.Name.Equals("Id"))
                {
                    prop.SetValue(s, 250);
                }
                else if (prop.Name.Equals("Name"))
                {
                    prop.SetValue(s, "AWESOME");
                }
                else if (prop.Name.Equals("Address"))
                {
                    prop.SetValue(s, "Adelaide");
                }
            }

            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} -- {prop.Name} -- {prop.GetValue(s)}");
            }

            Console.WriteLine("Fields:");
            foreach (var field in type.GetFields())
            {
                Console.WriteLine($"{field.FieldType} -- {field.Name} -- {field.GetValue(s)}");
            }

            foreach (var field in type.GetFields())
            {
                if (field.Name.Equals("age"))
                {
                    field.SetValue(s, 88);
                }
            }

            foreach (var field in type.GetFields())
            {
                Console.WriteLine($"{field.FieldType} -- {field.Name} -- {field.GetValue(s)}");
            }

            Console.WriteLine(s.ToString());

            // method 2 for get property
            PropertyInfo property = type.GetProperty("Id");
        }
    }
}
