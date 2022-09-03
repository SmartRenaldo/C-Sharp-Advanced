using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_CallGenericityMethodsByReflection
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

        public void Delete<T, W, S>(T t, W w, S s)
        {
            Console.WriteLine("Type 1: {0}, Type 2: {1}, Type 3: {2}",
                t.GetType().Name, w.GetType().Name, s.GetType().Name);
        }
    }
}
