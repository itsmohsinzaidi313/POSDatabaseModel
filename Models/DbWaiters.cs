using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Waiters")]
    public class DbWaiters
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public double CommissionPercentage { get; set; }
        public double CommissionAmount { get; set; }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
    }
}
