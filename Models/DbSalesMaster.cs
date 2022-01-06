using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("SalesMaster")]
    public class DbSalesMaster
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int OrderNo { get; set; }
        public int TokenNo { get; set; }
        public int OrderTypesId { get; set; }
        public DbOrderTypes OrderTypes { get; set; }
        [NotMapped]
        public OrderType OrderType
        {
            get
            {
                foreach (var x in new List<OrderType> { OrderType.DineInIndoor, OrderType.DineInOutdoor, OrderType.TakeAway, OrderType.Delivery })
                {
                    if (OrderTypesId == (int)x)
                    {
                        return x;
                    }
                }
                return OrderType.Undefined;
            }
            set
            {
                OrderTypesId = (int)value;
            }
        }
        public DateTime SaleDate { get; set; }
        public int Persons { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double NetAmount { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double SubTotal { get; set; }
        public bool BillCreated { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double ExtraCharges { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double DeliveryCharges { get; set; }
        public int TableId { get; set; }
        public DbTables Table { get; set; }
        public int WaiterId { get; set; }
        public DbWaiters Waiter { get; set; }
        public int RiderId { get; set; }
        public DbRiders Rider { get; set; }
        public int TaxId { get; set; }
        public DbTaxes Tax { get; set; }
        public int DiscountDetailId { get; set; }
        public DbDiscountsDetails DiscountDetail { get; set; }
        public int OrderStatusesId { get; set; }
        public DbOrderStatuses OrderStatuses { get; set; }
        [NotMapped]
        public OrderStatus OrderStatus
        {
            get
            {
                foreach (var x in new List<OrderStatus> { OrderStatus.Paid, OrderStatus.Pending, OrderStatus.Deleted, OrderStatus.FullRefund, OrderStatus.PartialRefund })
                {
                    if (OrderStatusesId == (int)x)
                    {
                        return x;
                    }
                }
                return OrderStatus.Undefined;
            }
            set
            {
                OrderStatusesId = (int)value;
            }
        }
        public int PaymentModesId { get; set; }
        public DbPaymentModes PaymentModes { get; set; }
        [NotMapped]
        public PaymentMode PaymentMode
        {
            get
            {
                foreach (var x in new List<PaymentMode> { PaymentMode.Cash, PaymentMode.Card, PaymentMode.Voucher, PaymentMode.Cheque, PaymentMode.Online, PaymentMode.Mixed, PaymentMode.Credit })
                {
                    if (PaymentModesId == (int)x)
                    {
                        return x;
                    }
                }
                return PaymentMode.Undefined;
            }
            set
            {
                PaymentModesId = (int)value;
            }
        }
        public int UsersId { get; set; }
        public DbUsers Users { get; set; }
        public int CounterId { get; set; }
        public DbCounters Counters { get; set; }
        public int CustomerId { get; set; }
        public DbCustomers Customer { get; set; }
        public int ShiftLogId { get; set; }
        public DbShiftLogs ShiftLog { get; set; }
        public List<DbSalesDetails> SalesDetails { get; set; }
        public bool Truncated { get; set; }
    }
}
