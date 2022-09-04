using _25_AttributeUseCase3.ValidateExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Leader leader1 = new Leader()
            {
                Id = 10,
                Phone = 23424535,
                Name = "awesome renaldo"
            };

            if (leader1.Validate())
            {
                Console.WriteLine("Validate successfully");
            }
            else
            {
                Console.WriteLine("Validate failed");
            }

            Leader leader2 = new Leader()
            {
                Id = 10,
                Phone = 2342445535,
                Name = "awesome renaldo"
            };

            if (leader2.Validate())
            {
                Console.WriteLine("Validate successfully");
            }
            else
            {
                Console.WriteLine("Validate failed");
            }
        }
    }
}
