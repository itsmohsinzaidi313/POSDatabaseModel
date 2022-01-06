using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("SalesDealDetails")]
    public class DbSalesDealItems
    {
        public int Id { get; set; }
        [Column("Quantity", TypeName = "decimal(4,3")]
        public double Quantity { get; set; }
        public int Choice { get; set; }
        public bool Canceled { get; set; }
        public int MenuDetailId { get; set; }
        public DbMenuDetails MenuDetail { get; set; }
        public int SalesDetailId { get; set; }
        public DbSalesDetails SalesDetail { get; set; }
        public bool Truncated { get; set; }
    }
}
