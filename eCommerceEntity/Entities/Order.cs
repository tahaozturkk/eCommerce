using eCommerceEntity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceEntity.Entities
{
    public class Order: BaseEntity
    {
        public Basket Basket { get; set; }
        public string OrderStatus { get; set; }
        public bool IsComplete { get; set; }
        public DateTime OrderCreatedData { get; set; }
        public DateTime OrderUpdatedData { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
