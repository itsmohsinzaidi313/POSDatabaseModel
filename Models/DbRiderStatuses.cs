using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("RiderStatuses")]
    public class DbRiderStatuses
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string StatusName { get; set; }
        [NotMapped]
        public RiderStatus Status
        {
            get
            {
                var list = new List<RiderStatus> { RiderStatus.Assigned, RiderStatus.Unassigned };
                foreach (var x in list)
                {
                    if (Id == (int)x)
                    {
                        return x;
                    }
                }
                return RiderStatus.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
