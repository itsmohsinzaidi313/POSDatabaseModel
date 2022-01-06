using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Menu")]
    public class DbMenu
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public DbCategories Category { get; set; }
        public int ItemTypeId { get; set; }
        public DbItemTypes ItemTypes { get; set; }
        [NotMapped]
        public ItemType ItemType
        {
            get
            {
                foreach (var x in new List<ItemType> { ItemType.Item, ItemType.Deal, ItemType.AddOn })
                {
                    if (ItemTypeId == (int)x)
                    {
                        return x;
                    }
                }
                return ItemType.Undefined;
            }
            set
            {
                ItemTypeId = (int)value;
            }
        }
        [Column(TypeName = "decimal(8,2)")]
        public double DiscountAmount { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public double DiscountPercentage { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public double TaxPercentage { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
        public List<DbMenuDetails> MenuDetails { get; set; }
        public List<DbMenuDealItems> MenuDeals { get; set; }
        public List<DbMenuAddons> MenuAddons { get; set; }
    }
}
