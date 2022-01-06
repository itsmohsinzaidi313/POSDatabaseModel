using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDatabaseModel.Models
{
    [Table("WaiterCommissions")]
    public class DbSalesWaiterCommissions
    {
        public int Id { get; set; }
        public int SalesMasterId { get; set; }
        public DbSalesMaster SalesMaster { get; set; }
        public int WaiterId { get; set; }
        public DbWaiters Waiter { get; set; }
        public double Commission { get; set; }
        public bool Truncated { get; set; }
    }
}
