using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HandleAttributesByReflection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int age;

        public override string ToString()
        {
            return "Student " + Id + " " + Name + " " + Address + " " + age;
        }

        public void Method1()
        {
            Console.WriteLine("Method 1 for {0}", this.GetType());
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 for {0}", this.GetType());
        }

        public void Method2(string s)
        {
            Console.WriteLine("Method 2 for {0}", this.GetType());
            Console.WriteLine("\t" + s);
        }

        public void Method2(string s, int i)
        {
            Console.WriteLine("Method 2 for {0}", this.GetType());
            Console.WriteLine("\t" + s);
            Console.WriteLine("\t" + i);
        }

        private void Method3()
        {
            Console.WriteLine("Method 3 for {0}", this.GetType());
        }

        private void Method3(int i)
        {
            Console.WriteLine("Method 3 for {0}", this.GetType());
            Console.WriteLine("\t" + i);
        }

        public static void Method3(string s)
        {
            Console.WriteLine("Method 3 for {0}", typeof(Student));
            Console.WriteLine("\t" + s);
        }
    }
}
