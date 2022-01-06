using POSDatabaseModel.Models;
using System;

namespace POSDatabaseModel.Classes
{
    public class CustomerLedgerDesciption
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string VoucherNo => CustomerLedger.VoucherNo;
        public DateTime DateTime => CustomerLedger.DateTime;
        public string CustomerName => Customer.Name;
        public string CNIC => Customer.CNIC;
        public string Contact => Customer.Contact;
        public string Address => Customer.Address;
        internal DbCustomerLedger CustomerLedger { get; set; }
        internal DbCustomers Customer { get; set; }
    }
}
