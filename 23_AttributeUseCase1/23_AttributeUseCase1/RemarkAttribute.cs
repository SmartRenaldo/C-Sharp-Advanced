using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_AttributeUseCase1
{
    [AttributeUsage(AttributeTargets.Field)]
    public class RemarkAttribute : Attribute
    {
        /// <summary>
        /// state attribute
        /// </summary>
        /// <param name="remark"></param>
        public RemarkAttribute(string remark)
        {
            this.Remark = remark;
        }

        public string Remark { get; private set; }
    }
}
