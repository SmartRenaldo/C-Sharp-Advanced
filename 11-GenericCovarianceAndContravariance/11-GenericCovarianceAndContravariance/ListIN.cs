using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GenericCovarianceAndContravariance
{
    public class ListIN<T> : IListIN<T>
    {
        public void Show(T item)
        {
            Console.WriteLine(item);
        }
    }
}
