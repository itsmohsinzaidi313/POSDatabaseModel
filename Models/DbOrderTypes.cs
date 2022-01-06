using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("OrderTypes")]
    public class DbOrderTypes
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string OrderTypeName { get; set; }
        [NotMapped]
        public OrderType OrderType
        {
            get
            {
                foreach (var x in new List<OrderType> { OrderType.DineInIndoor, OrderType.DineInOutdoor, OrderType.TakeAway, OrderType.Delivery })
                {
                    if (Id == (int)x)
                    {
                        return x;
                    }
                }
                return OrderType.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
