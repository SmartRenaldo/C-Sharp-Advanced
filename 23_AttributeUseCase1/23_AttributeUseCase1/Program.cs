using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_AttributeUseCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeState state = CoffeeState.Large;

            /*if (state == CoffeeState.Small)
            {
                Console.WriteLine("Small Coffee");
            }
            else if (state == CoffeeState.Meduim)
            {
                Console.WriteLine("Meduim Coffee");
            }
            else if (state == CoffeeState.Large)
            {
                Console.WriteLine("Large Coffee");
            }*/

            AttributeInvoke attributeInvoke = new AttributeInvoke();
            Console.WriteLine(attributeInvoke.GetRemark(state) + " Coffee");
        }
    }
}
