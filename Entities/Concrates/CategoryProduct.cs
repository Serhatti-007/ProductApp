using Entities.Abstarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrates
{
    public class CategoryProduct:BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }

    }
}
