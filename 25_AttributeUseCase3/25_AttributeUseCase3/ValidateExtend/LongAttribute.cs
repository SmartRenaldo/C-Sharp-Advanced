using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3.ValidateExtend
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LongAttribute : AbstractValidateAttribute
    {
        private long lenght;

        public LongAttribute (long lenght)
        {
            this.lenght = lenght;
        }

        public override bool Validate(object value)
        {
            return value != null && value.ToString().Length == 10;
        }
    }
}
