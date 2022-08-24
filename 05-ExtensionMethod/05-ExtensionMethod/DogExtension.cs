using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExtensionMethod
{
    public static class DogExtension
    {
        public static void showDog(this Dog dog)
        {
            Console.WriteLine(dog.GetName());
        }
    }
}
