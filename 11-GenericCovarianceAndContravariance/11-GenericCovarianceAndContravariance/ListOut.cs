using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GenericCovarianceAndContravariance
{
    public class ListOut<T> : IListOut<T>
    {
        public T GetT()
        {
            // return null for reference type, and return 0 for primitive type
            return default(T);
        }
    }
}
