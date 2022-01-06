using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Discounts")]
    public class DbDiscounts
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public List<DbDiscountsDetails> DiscountsDetails { get; set; }
        public List<DbSalesMaster> SalesMasters { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
