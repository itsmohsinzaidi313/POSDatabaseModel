using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Tables")]
    public class DbTables
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public int StatusId { get; set; }
        public DbTableStatuses Status { get; set; }
        [NotMapped]
        public TableStatus TableStatus
        {
            get
            {
                foreach (var x in new List<TableStatus> { })
                {
                    if (StatusId == (int)x)
                        return x;
                }
                return TableStatus.Undefined;
            }
            set
            {
                StatusId = (int)value;
            }
        }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
