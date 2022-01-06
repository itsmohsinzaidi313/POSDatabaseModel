using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("DiscountsDetails")]
    public class DbDiscountsDetails
    {
        public int Id { get; set; }
        public int DiscountsId { get; set; }
        public DbDiscounts Discounts { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double Percentage { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double Amount { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double Limit { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int DiscountTypesId { get; set; }
        public DbDiscountTypes DiscountTypes { get; set; }
        [NotMapped]
        public DiscountType DiscountType
        {
            get
            {
                foreach (var x in new List<DiscountType> { DiscountType.Daily, DiscountType.Limited, DiscountType.Unlimited })
                {
                    if (DiscountTypesId == (int)x)
                        return x;
                }
                return DiscountType.Undefined;
            }
            set
            {
                DiscountTypesId = (int)value;
            }
        }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}