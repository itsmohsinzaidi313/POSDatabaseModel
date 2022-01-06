using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("DayLogs")]
    public class DbDayLogs
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string DayNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public int OpeningUserId { get; set; }
        public DbUsers OpeningUser { get; set; }
        public int ClosingUserId { get; set; }
        public DbUsers ClosingUser { get; set; }
        public int OpeningCounterId { get; set; }
        public DbCounters OpeningCounter { get; set; }
        public int ClosingCounterId { get; set; }
        public DbCounters ClosingCounter { get; set; }
        public int SettingsId { get; set; }
        public DbDaySettings Settings { get; set; }
        public bool Closed { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
