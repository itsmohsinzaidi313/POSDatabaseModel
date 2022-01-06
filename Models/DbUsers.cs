using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Users")]
    public class DbUsers
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public int UserSettingId { get; set; }
        public DbUserSettings UserSettings { get; set; }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
        public List<DbShiftLogs> ShiftLogs { get; set; }
        public List<DbCounterLedger> CounterLedgers { get; set; }
    }
}
