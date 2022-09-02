using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateObjWithParamByReflection
{
    public class DbPostgreSQL : DbInterface
    {
        private string _sql;

        public DbPostgreSQL()
        {
            Console.WriteLine(111);
            //Console.WriteLine("Constructor {0}", this.GetType().Name);
        }

        public void Query()
        {
            //Console.WriteLine("{0}.Query", this.GetType().Name);
        }
    }
}
