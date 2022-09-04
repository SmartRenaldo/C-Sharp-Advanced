using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3.ValidateExtend
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringAttribute : AbstractValidateAttribute
    {
        private int MinimumLength = 0;
        private int MaximumLength = 0;

        public StringAttribute (int minimumLength, int maximumLength)
        {
            MinimumLength = minimumLength;
            MaximumLength = maximumLength;
        }

        public override bool Validate(object value)
        {
            return value != null && value.ToString().Length >= MinimumLength 
                && value.ToString().Length <= MaximumLength;
        }
    }
}
