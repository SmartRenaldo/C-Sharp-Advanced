using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateObjWithParamByReflection
{
    public class DbSQLite : DbInterface
    {
        private string _sql;
        private int value;

        public DbSQLite()
        {
            Console.WriteLine("Constructor {0}", this.GetType().Name);
        }

        public DbSQLite(string sql)
        {
            _sql = sql;
            Console.WriteLine("Constructor {0} with a {1} parameter", this.GetType().Name, sql.GetType());
        }

        public DbSQLite(int value)
        {
            this.value = value;
            Console.WriteLine("Constructor {0} with a {1} parameter", this.GetType().Name, value.GetType());
        }

        public DbSQLite(string sql, int value)
        {
            this._sql = sql;
            this.value = value;
            Console.WriteLine("Constructor {0} with {1} and {2} parameters", 
                this.GetType().Name, sql.GetType(), value.GetType());
        }

        public void Query()
        {
            Console.WriteLine("{0}.Query", this.GetType().Name);
        }
    }
}
