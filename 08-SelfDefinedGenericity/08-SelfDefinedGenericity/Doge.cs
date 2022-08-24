using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SelfDefinedGenericity
{
    public class Doge<T>
    {
        private T Value;

        public Doge(T value)
        {
            Value = value;
        }

        public T GetValue()
        {
            return Value;
        }
    }
}
