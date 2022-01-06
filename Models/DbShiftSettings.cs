using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("ShiftSettings")]
    public class DbShiftSettings
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [NotMapped]
        public RestaurantShiftPolicy ShiftPolicy
        {
            get
            {
                foreach (RestaurantShiftPolicy x in new List<RestaurantShiftPolicy> { RestaurantShiftPolicy.Strict, RestaurantShiftPolicy.Lenient })
                {
                    if (ShiftPolicyId == (int)x)
                        return x;
                }
                return RestaurantShiftPolicy.Undefined;
            }
            set
            {
                ShiftPolicyId = (int)value;
            }
        }
        public int ShiftPolicyId { get; set; }
        public DbShiftPolicies ShiftPolicies { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
