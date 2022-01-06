using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("MenuDealItems")]
    public class DbMenuDealItems
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DbMenu Item { get; set; } 
        public int Choice { get; set; }
        public double ItemQuantity { get; set; }
        public int MenuId { get; set; }
        public DbMenu Menu { get; set; }
        public int MenuItemsId { get; set; }
        public int MenuDetailId { get; set; }
        public DbMenuDetails MenuDetail { get; set; }
        public bool Truncated { get; set; }
    }
}
