using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("MenuAddons")]
    public class DbMenuAddons
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double Price { get; set; }
        public bool Enabled { get; set; }
        public int MenuId { get; set; }
        public DbMenu Menu { get; set; }
        public bool Truncated { get; set; }
    }
}
