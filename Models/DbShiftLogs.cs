using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("ShiftLogs")]
    public class DbShiftLogs
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string ShiftNumber { get; set; }
        public int DayLogId { get; set; }
        public DbDayLogs DayLog { get; set; }
        public DateTime OpeningTime { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double OpeningAmount { get; set; }
        public DateTime ClosingTime { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double ClosingAmount { get; set; }
        public int OpeningUserId { get; set; }
        public DbUsers OpeningUser { get; set; }
        public int ClosingUserId { get; set; }
        public DbUsers ClosingUser { get; set; }
        public int OpeningCounterId { get; set; }
        public DbCounters OpeningCounter { get; set; }
        public int ClosingCounterId { get; set; }
        public DbCounters ClosingCounter { get; set; }
        public int ShiftSettingsId { get; set; }
        public DbShiftSettings ShiftSettings { get; set; }
        public bool Closed { get; set; }
        public bool Truncated { get; set; }
    }
}
