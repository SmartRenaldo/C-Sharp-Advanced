using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3.ValidateExtend
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            return value != null && !string.IsNullOrWhiteSpace(value.ToString());
        }
    }
}
