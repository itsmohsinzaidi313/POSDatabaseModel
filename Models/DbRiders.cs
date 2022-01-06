using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Riders")]
    public class DbRiders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double CommissionPercentage { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double CommissionAmount { get; set; }
        public int RiderStatusesId { get; set; }
        public DbRiderStatuses RiderStatuses { get; set; }
        public RiderStatus RiderStatus
        {
            get
            {
                foreach (var x in new List<RiderStatus>() { RiderStatus.Assigned, RiderStatus.Unassigned })
                {
                    if (RiderStatusesId == (int)x)
                        return x;
                }
                return RiderStatus.Undefined;
            }
            set
            {
                RiderStatusesId = (int)value;
            }
        }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
    }
}
