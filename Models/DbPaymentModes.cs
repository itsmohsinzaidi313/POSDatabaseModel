using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("PaymentModes")]
    public class DbPaymentModes
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [NotMapped]
        public PaymentMode PaymentMode
        {
            get
            {
                var list = new List<PaymentMode> { PaymentMode.Cash, PaymentMode.Card, PaymentMode.Voucher, PaymentMode.Cheque, PaymentMode.Online, PaymentMode.Mixed, PaymentMode.Credit };
                foreach (var x in list)
                {
                    if (Id == (int)x)
                    {
                        return x;
                    }
                }
                return PaymentMode.Undefined;
            }
        }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
