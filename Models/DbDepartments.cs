using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Departments")]
    public class DbDepartments
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
    }
}
