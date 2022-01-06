using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    public class DbCustomerLedgerDetails
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double DebitAmount { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double CreditAmount { get; set; }
        public int CustomersId { get; set; }
        public DbCustomers Customers { get; set; }
        public int PaymentModeId { get; set; }
        public DbPaymentModes PaymentModes { get; set; }
        [NotMapped]
        public PaymentMode PaymentMode
        {
            get
            {
                foreach (var x in new List<PaymentMode> { PaymentMode.Cash, PaymentMode.Card, PaymentMode.Voucher, PaymentMode.Cheque, PaymentMode.Online, PaymentMode.Mixed, PaymentMode.Credit })
                {
                    if (PaymentModeId == (int)x)
                        return x;
                }
                return PaymentMode.Undefined;
            }
            set
            {
                PaymentModeId = (int)value;
            }
        }
        public int CustomerLedgerId { get; set; }
        public DbCustomerLedger CustomerLedger { get; set; }
        public bool Truncated { get; set; }
    }
}
