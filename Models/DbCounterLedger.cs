using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("CounterLedger")]
    public class DbCounterLedger
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string VoucherNo { get; set; }
        public DateTime DateTime { get; set; }
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
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
        public List<DbCounterLedgerDetails> CounterLedgerDetails { get; set; }
    }
}
