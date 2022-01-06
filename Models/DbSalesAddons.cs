using RMSEnumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("SalesAddons")]
    public class DbSalesAddons
    {
        public int Id { get; set; }
        public int MenuAddonId { get; set; }
        public DbMenuAddons MenuAddon { get; set; }
        public int SalesDetailId { get; set; }
        public DbSalesDetails SalesDetail { get; set; }
        public bool Canceled { get; set; }
        public bool Truncated { get; set; }
    }
}
