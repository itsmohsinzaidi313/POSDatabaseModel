using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Categories")]
    public class DbCategories
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public int DepartmentId { get; set; }
        public DbDepartments Department { get; set; }
        public bool Truncated { get; set; }
    }
}
