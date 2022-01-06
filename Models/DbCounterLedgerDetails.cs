using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("CounterLedgerDetails")]
    public class DbCounterLedgerDetails
    {
        public int Id { get; set; }
        public int CountersId { get; set; }
        public DbCounters Counters { get; set; }
        public int UsersId { get; set; }
        public DbUsers Users { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double CreditAmount { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double DebitAmount { get; set; }
        public int CounterLedgerId { get; set; }
        public DbCounterLedger CounterLedger { get; set; }
        public bool Truncated { get; set; }
    }
}
