using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("DaySettings")]
    public class DbDaySettings
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public int Minutes { get; set; }
        [NotMapped]
        public RestaurantDayPolicy DayPolicy
        {
            get
            {
                foreach (var x in new List<RestaurantDayPolicy> { RestaurantDayPolicy.Strict, RestaurantDayPolicy.Lenient })
                {
                    if (DayPolicyId == (int)x)
                        return x;
                }
                return RestaurantDayPolicy.Undefined;
            }
            set
            {
                DayPolicyId = (int)value;
            }
        }
        public int DayPolicyId{ get; set; }
        public DbDayPolicies DayPolicies { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
