using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AttributeUseCase3.ValidateExtend
{
    public class Leader
    {
        public int Id { get; set; }

        [Required]
        [String(2, 100)]
        public string Name { get; set; }

        [Required]
        [Long(10)]
        public long Phone { get; set; }
    }
}
