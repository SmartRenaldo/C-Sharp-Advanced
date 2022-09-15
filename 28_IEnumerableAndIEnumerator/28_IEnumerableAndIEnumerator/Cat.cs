using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_IEnumerableAndIEnumerator
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Cat (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Treat(int numberOfTreats)
        {
            Console.WriteLine("Name: {0}, age: {1}, number of treats: {2}", Name, Age, numberOfTreats);
        }
    }
}
