using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("ItemTypes")]
    public class DbItemTypes
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string ItemTypeName { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
