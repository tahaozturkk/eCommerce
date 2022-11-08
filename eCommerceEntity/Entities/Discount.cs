using eCommerceEntity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceEntity.Entities
{
    public class Discount: BaseEntity
    {
        public Option Option { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
