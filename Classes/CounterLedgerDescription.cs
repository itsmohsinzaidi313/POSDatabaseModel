using POSDatabaseModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDatabaseModel.Classes
{
    public class CounterLedgerDescription
    {
        public string VoucherNo => DbCounterLedger.VoucherNo;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string User => DbUser.Name;
        public string CounterName => DbCounter.Name;
        public DateTime DateTime => DbCounterLedger.DateTime;
        internal DbCounters DbCounter { get; set; }
        internal DbUsers DbUser { get; set; }
        internal DbCounterLedger DbCounterLedger { get; set; }
    }
}
