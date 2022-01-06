using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("DayPolicies")]
    public class DbDayPolicies
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Policy { get; set; }
        [NotMapped]
        public RestaurantDayPolicy DayPolicy
        {
            get
            {
                foreach (RestaurantDayPolicy x in new List<RestaurantDayPolicy> { RestaurantDayPolicy.Default, RestaurantDayPolicy.Strict, RestaurantDayPolicy.Lenient })
                {
                    if (Id == (int)x)
                        return x;
                }
                return RestaurantDayPolicy.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
