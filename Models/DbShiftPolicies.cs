using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("ShiftPolicies")]
    public class DbShiftPolicies
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Policy { get; set; }
        public RestaurantShiftPolicy ShiftPolicy
        {
            get
            {
                foreach (RestaurantShiftPolicy x in new List<RestaurantShiftPolicy> { RestaurantShiftPolicy.Default, RestaurantShiftPolicy.Strict, RestaurantShiftPolicy.Lenient })
                {
                    if (Id == (int)x)
                        return x;
                }
                return RestaurantShiftPolicy.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
