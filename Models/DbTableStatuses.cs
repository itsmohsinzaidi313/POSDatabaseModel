using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("TableStatuses")]
    public class DbTableStatuses
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [NotMapped]
        public TableStatus TableStatus
        {
            get
            {
                foreach (TableStatus x in new List<TableStatus> { TableStatus.Reserved, TableStatus.Occupied, TableStatus.Unoccupied })
                {
                    if (Id == (int)x)
                        return x;
                }
                return TableStatus.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
