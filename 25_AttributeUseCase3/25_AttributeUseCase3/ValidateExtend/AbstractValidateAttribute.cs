﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3.ValidateExtend
{
    public abstract class AbstractValidateAttribute : Attribute
    {
        public abstract bool Validate(object value);
    }
}
