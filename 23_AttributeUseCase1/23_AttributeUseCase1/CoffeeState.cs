using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_AttributeUseCase1
{
    public enum CoffeeState
    {
        [Remark("Small")]
        Small = 0,

        [Remark("Meduim")]
        Meduim = 1,

        [Remark("Large")]
        Large = 2
    }
}
