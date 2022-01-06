using POSDatabaseModel.Classes;
using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;

namespace POSDatabaseModel.Models
{
    [Table("CustomerLedger")]
    public class DbCustomerLedger
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string VoucherNo { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [NotMapped]
        public CustomerLedgerDesciption EntryDesciption
        {
            get => JsonSerializer.Deserialize<CustomerLedgerDesciption>(Description);
            //set
            //{
            //    value.CustomerLedger = this;
            //    using (var context = new POSContext())
            //    {
            //        value.Customer = (from DbCustomers x in context.DbCustomers.Cast<DbCustomers>()
            //                          where x.Id == CustomerId
            //                          select x).FirstOrDefault();
            //    }
            //    value.
            //    Description = JsonSerializer.Serialize(value);
            //}
        }
        public DateTime DateTime { get; set; }
        public int SalesMasterId { get; set; }
        public DbSalesMaster SaleMaster { get; set; }
        public int CounterId { get; set; }
        public DbCounters Counter { get; set; }
        public int UserId { get; set; }
        public DbUsers User { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
        public List<DbCustomerLedgerDetails> CustomerLedgerDetails { get; set; }

    }
}
