using System.Xml.Linq;

namespace _05_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog()
            {
                Name = "Scott",
                Age = 5,
                Type = "Golden Hair"
            };

            DogExtension.showDog(dog);

            CalculateImpl c = new CalculateImpl();
            int res1 = c.Sub(1, 2);
            Console.WriteLine($"1 - 2 = {res1}");
            int res2 = c.Multiply(2, 3);
            Console.WriteLine($"2 * 3 = {res2}");
        }
    }
}