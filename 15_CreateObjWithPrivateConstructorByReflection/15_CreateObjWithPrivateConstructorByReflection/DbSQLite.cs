using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CreateObjWithPrivateConstructorByReflection
{
    public class DbSQLite : DbInterface
    {
        private string _sql;
        private int value;

        private DbSQLite()
        {
            Console.WriteLine("Constructor {0}", this.GetType().Name);
        }

        public void Query()
        {
            Console.WriteLine("{0}.Query", this.GetType().Name);
        }
    }
}
