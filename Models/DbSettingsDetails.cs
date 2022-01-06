using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("SettingsDetails")]
    public class DbSettingsDetails
    {
        public int Id { get; set; }
        public int SettingsId { get; set; }
        public DbSettings Settings { get; set; }
        [StringLength(50)]
        public string Value { get; set; }
        public bool Truncated { get; set; }
    }
}
