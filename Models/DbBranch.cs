using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Branch")]
    public class DbBranch
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string BranchUniqueId { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
        public List<DbDepartments> Departments { get; set; }
        public List<DbUsers> Users { get; set; }
        public List<DbRiders> Riders { get; set; }
        public List<DbWaiters> Waiters { get; set; }
        public List<DbCounters> Counters { get; set; }
        public List<DbDiscounts> Discounts { get; set; }
        public List<DbTaxes> Taxes { get; set; }
        public List<DbSettings> Settings { get; set; }
        public List<DbCustomers> Customers { get; set; }
        public List<DbDayLogs> DayLogs { get; set; }
        public List<DbCounterLedger> CounterLedgers { get; set; }
        public List<DbCustomerLedger> CustomerLedgers { get; set; }
    }
}
