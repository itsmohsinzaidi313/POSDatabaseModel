using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("MenuDetails")]
    public class DbMenuDetails
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [Column("Price", TypeName = "decimal(18,2)")]
        public double Price { get; set; }
        [Column("DiscountPercentage", TypeName = "decimal(18,2)")]
        public double DiscountPercentage { get; set; }
        [Column("DiscountAmount", TypeName = "decimal(18,2)")]
        public double DiscountAmount { get; set; }
        [Column("TaxPercentage", TypeName = "decimal(18,2)")]
        public double TaxPercentage { get; set; }
        public bool Enabled { get; set; }
        public int MenuId { get; set; }
        public DbMenu Menu { get; set; }
        public bool Truncated { get; set; }
    }
}
