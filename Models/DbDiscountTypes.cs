using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("DiscountTypes")]
    public class DbDiscountTypes
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
        [NotMapped]
        public DiscountType TypeOfDiscount
        {
            get
            {
                foreach (DiscountType x in new List<DiscountType> { DiscountType.Daily, DiscountType.Limited, DiscountType.Unlimited })
                {
                    if (Id == (int)x)
                        return x;
                }
                return DiscountType.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
