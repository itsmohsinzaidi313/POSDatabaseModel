using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Customers")]
    public class DbCustomers
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Contact { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(15)]
        public string CNIC { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
