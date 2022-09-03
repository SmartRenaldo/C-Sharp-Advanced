using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_CreateObjWithGenericityByReflection
{
    public class DbSQLite<T, W, S> : DbInterface
    {
        private string _sql;
        private int value;

        public DbSQLite()
        {
            Console.WriteLine(1111111);
            Console.WriteLine("Constructor {0}", this.GetType().Name);
        }

        public void Query()
        {
            Console.WriteLine("{0}.Query", this.GetType().Name);
        }
    }
}
