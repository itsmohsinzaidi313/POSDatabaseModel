using POSDatabaseModel.Models;
using Microsoft.EntityFrameworkCore;
using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POSDatabaseModel
{
    public class POSSeedValues
    {
        public ModelBuilder ModelBuilder { get; set; }
        public POSSeedValues()
        {
        }
        public POSSeedValues(ModelBuilder modelBuilder)
        {
            ModelBuilder = modelBuilder;
            DiscountTypes();
            TableStatuses();
            RiderStatuses();
            PaymentModes();
            OrderTypes();
            OrderStatuses();
            ItemTypes();
            ShiftPolicies();
            DayPolicies();
            UserPrivileges();
            Units();
        }

        public void DiscountTypes() => new List<DiscountType> { DiscountType.Daily, DiscountType.Limited, DiscountType.Unlimited }.ForEach(x => ModelBuilder.Entity<DbDiscountTypes>().HasData(new DbDiscountTypes { Id = (int)x, Type = x.ToString() }));
        public void PaymentModes() => new List<PaymentMode> { PaymentMode.Cash, PaymentMode.Card, PaymentMode.Voucher, PaymentMode.Cheque, PaymentMode.Online, PaymentMode.Mixed, PaymentMode.Credit }.ForEach(x => ModelBuilder.Entity<DbPaymentModes>().HasData(new DbPaymentModes { Id = (int)x, Name = x.ToString() }));
        public void TableStatuses() => new List<TableStatus> { TableStatus.Reserved, TableStatus.Occupied, TableStatus.Unoccupied }.ForEach(x => ModelBuilder.Entity<DbTableStatuses>().HasData(new DbTableStatuses { Id = (int)x, Status = x.ToString() }));
        public void RiderStatuses() => new List<RiderStatus> { RiderStatus.Assigned, RiderStatus.Unassigned }.ForEach(x => ModelBuilder.Entity<DbRiderStatuses>().HasData(new DbRiderStatuses { Id = (int)x, StatusName = x.ToString() }));
        public void OrderTypes() => new List<OrderType> { OrderType.DineInIndoor, OrderType.DineInOutdoor, OrderType.TakeAway, OrderType.Delivery }.ForEach(x => ModelBuilder.Entity<DbOrderTypes>().HasData(new DbOrderTypes { Id = (int)x, OrderTypeName = x.ToString() }));
        public void OrderStatuses() => new List<OrderStatus> { OrderStatus.Paid, OrderStatus.Pending, OrderStatus.Deleted, OrderStatus.FullRefund, OrderStatus.PartialRefund }.ForEach(x => ModelBuilder.Entity<DbOrderStatuses>().HasData(new DbOrderStatuses { Id = (int)x, Status = x.ToString() }));
        public void ItemTypes() => new List<ItemType> { ItemType.Item, ItemType.Deal, ItemType.AddOn }.ForEach(x => ModelBuilder.Entity<DbItemTypes>().HasData(new DbItemTypes { Id = (int)x, ItemTypeName = x.ToString(), Enabled = true }));
        public void ShiftPolicies() => new List<RestaurantShiftPolicy> { RestaurantShiftPolicy.Default, RestaurantShiftPolicy.Strict, RestaurantShiftPolicy.Lenient }.ForEach(x => ModelBuilder.Entity<DbShiftPolicies>().HasData(new DbShiftPolicies { Id = (int)x, Policy = x.ToString() }));
        public void DayPolicies() => new List<RestaurantDayPolicy> { RestaurantDayPolicy.Default, RestaurantDayPolicy.Strict, RestaurantDayPolicy.Lenient }.ForEach(x => ModelBuilder.Entity<DbDayPolicies>().HasData(new DbDayPolicies { Id = (int)x, Policy = x.ToString() }));
        public void UserPrivileges() => new List<UserPrivilege> { UserPrivilege.Administrator, UserPrivilege.BranchManager, UserPrivilege.Manager, UserPrivilege.OperationsManager, UserPrivilege.Cashier }.ForEach(x => ModelBuilder.Entity<DbUserPrivileges>().HasData(new DbUserPrivileges { Id = (int)x, PrivilegeName = x.ToString() }));
        public void Units() => new List<Units> { RMSEnumerations.Units.Amount, RMSEnumerations.Units.Percentage }.ForEach(x => ModelBuilder.Entity<DbUnits>().HasData(new DbUnits { Id = (int)x, UnitName = x.ToString() }));
    }
}
