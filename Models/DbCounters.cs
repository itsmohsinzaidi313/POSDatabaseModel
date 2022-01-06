using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Counters")]
    public class DbCounters
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string IpAddress { get; set; }
        [StringLength(40)]
        public string UUID { get; set; }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
        public List<DbDayLogs> DayLogs { get; set; }
        public List<DbShiftLogs> ShiftLogs { get; set; }
        public List<DbCounterLedger> CounterLedgers { get; set; }
        public List<DbCustomerLedger> CustomerLegders { get; set; }
    }
}
