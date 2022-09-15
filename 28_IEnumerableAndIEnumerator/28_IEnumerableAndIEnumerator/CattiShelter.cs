using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_IEnumerableAndIEnumerator
{
    public class CattiShelter : IEnumerable<Cat>
    {
        public List<Cat> cats;

        public CattiShelter()
        {
            cats = new List<Cat>()
            {
                new Cat("Leili", 70),
                new Cat("Hancook", 30),
                new Cat("Tichi", 42),
                new Cat("Zoro", 21)
            };
        }

        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            return cats.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
