using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("SalesDetails")]
    public class DbSalesDetails
    {
        public int Id { get; set; }
        [Column("Quantity", TypeName = "decimal(4,3")]
        public double Quantity { get; set; }
        public bool Canceled { get; set; }
        public bool Printed { get; set; }
        public int MenuDetailsId { get; set; }
        public DbMenuDetails MenuDetails { get; set; }
        public int SalesMasterId { get; set; }
        public DbSalesMaster SalesMaster { get; set; }
        public List<DbSalesDealItems> SalesDealItems { get; set; }
        public List<DbSalesAddons> SalesAddonItems { get; set; }
        public bool Truncated { get; set; }
    }
}
