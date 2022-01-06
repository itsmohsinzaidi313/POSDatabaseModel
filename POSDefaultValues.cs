using POSDatabaseModel.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace POSDatabaseModel
{
    public class POSDefaultValues
    {
        public ModelBuilder ModelBuilder { get; set; }

        public POSDefaultValues(ModelBuilder modelBuilder)
        {
            ModelBuilder = modelBuilder;
            CounterLedgerDetails();
            CustomerLedgerDetails();
        }
        public void CounterLedgerDetails()
        {
            ModelBuilder.Entity<DbCounterLedgerDetails>()
                .Property("DebitAmount")
                .HasDefaultValue(0);
            ModelBuilder.Entity<DbCounterLedgerDetails>()
                .Property("CreditAmount")
                .HasDefaultValue(0);
            ModelBuilder.Entity<DbCounterLedgerDetails>()
                .Property("CountersId")
                .HasDefaultValue(0);
            ModelBuilder.Entity<DbCounterLedgerDetails>()
                .Property("UsersId")
                .HasDefaultValue(0);
        }
        public void CustomerLedgerDetails()
        {
            ModelBuilder.Entity<DbCustomerLedgerDetails>()
                .Property("DebitAmount")
                .HasDefaultValue(0);
            ModelBuilder.Entity<DbCustomerLedgerDetails>()
                .Property("CreditAmount")
                .HasDefaultValue(0);
            ModelBuilder.Entity<DbCustomerLedgerDetails>()
                .Property("CustomersId")
                .HasDefaultValue(0);
        }
    }
}
