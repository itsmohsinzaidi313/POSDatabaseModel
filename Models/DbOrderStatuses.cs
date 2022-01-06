using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("OrderStatuses")]
    public class DbOrderStatuses
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public OrderStatus OrderStatus 
        { 
            get
            {
                var list = new List<OrderStatus> { OrderStatus.Paid, OrderStatus.Pending, OrderStatus.Deleted, OrderStatus.FullRefund, OrderStatus.PartialRefund };
                foreach (var x in list)
                {
                    if (Status.Equals(x.ToString()))
                    {
                        return x;
                    }
                }
                return OrderStatus.Undefined;
            }
            
        }
        public bool Truncated { get; set; }
    }
}
