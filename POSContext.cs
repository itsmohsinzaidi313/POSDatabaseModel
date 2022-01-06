using POSDatabaseModel.Models;
using Microsoft.EntityFrameworkCore;

namespace POSDatabaseModel
{
    public class POSContext : DbContext
    {
        private const string _defaultConnectionString = @"Server=loco-pc\sqlexpress2014; Database=POSDatabase2021; User Id=sa; Password=123;";
        private readonly string _connectionString;
        private readonly bool _development;
        /// <summary>
        /// Provides database context for database interactions using in-memory database for testing.
        /// </summary>
        public POSContext() { _development = true; }
        /// <summary>
        /// Provides database context for database interactions.
        /// Provide a connection string to create database on desired server.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public POSContext(string server, string database, string username, string password)
        {
            _development = false;
            _connectionString = $@"Server={server}; Database={database}; User Id={username}; Password={password};"; ;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string x = string.Empty;
            if (_development)
            {
                base.OnConfiguring(
                    optionsBuilder.UseInMemoryDatabase("myDatabase"));
            }
            else
            {

                if (string.IsNullOrEmpty(_connectionString))
                    x = _defaultConnectionString;
                else
                    x = _connectionString;

                base.OnConfiguring(
                    optionsBuilder.UseSqlServer(x,
                    sqlServerOptionsAction: x => x.CommandTimeout(30)));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = new POSSeedValues(modelBuilder);
            _ = new POSDefaultValues(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DbBranch> DbBranch { get; set; }
        public DbSet<DbCategories> DbCategories { get; set; }
        public DbSet<DbCounters> DbCounters { get; set; }
        public DbSet<DbCounterLedger> DbCounterLedgers { get; set; }
        public DbSet<DbCounterLedgerDetails> DbCounterLedgerDetails { get; set; }
        public DbSet<DbCustomerLedger> DbCustomerLegder { get; set; }
        public DbSet<DbCustomerLedgerDetails> CustomerLedgerDetails { get; set; }
        public DbSet<DbCustomers> DbCustomers { get; set; }
        public DbSet<DbDayLogs> DbDayLogs { get; set; }
        public DbSet<DbDayPolicies> DbDayPolicies { get; set; }
        public DbSet<DbDaySettings> DbDaySettings { get; set; }
        public DbSet<DbDepartments> DbDepartments { get; set; }
        public DbSet<DbDiscounts> DbDiscounts { get; set; }
        public DbSet<DbDiscountsDetails> DbDiscountsDetails { get; set; }
        public DbSet<DbDiscountTypes> DbDiscountTypes { get; set; }
        public DbSet<DbItemTypes> DbItemTypes { get; set; }
        public DbSet<DbMenu> DbMenus { get; set; }
        public DbSet<DbMenuAddons> DbMenuAddons { get; set; }
        public DbSet<DbMenuDealItems> DbMenuDealItems { get; set; }
        public DbSet<DbMenuDetails> DbMenuDetails { get; set; }
        public DbSet<DbOrderStatuses> DbOrderStatuses { get; set; }
        public DbSet<DbOrderTypes> DbOrderTypes { get; set; }
        public DbSet<DbPaymentModes> DbPaymentModes { get; set; }
        public DbSet<DbRiders> DbRiders { get; set; }
        public DbSet<DbRiderStatuses> DbRiderStatuses { get; set; }
        public DbSet<DbSalesAddons> DbSalesAddons { get; set; }
        public DbSet<DbSalesDealItems> DbSalesDealItems { get; set; }
        public DbSet<DbSalesDetails> DbSalesDetails { get; set; }
        public DbSet<DbSalesMaster> DbSalesMaster { get; set; }
        public DbSet<DbSalesRiderCommissions> DbSalesRiderCommissions { get; set; }
        public DbSet<DbSalesWaiterCommissions> DbSalesWaiterCommissions { get; set; }
        public DbSet<DbSettings> DbSettings { get; set; }
        public DbSet<DbSettingsDetails> DbSettingsDetails { get; set; }
        public DbSet<DbShiftLogs> DbShiftLogs { get; set; }
        public DbSet<DbShiftPolicies> DbShiftPolicies { get; set; }
        public DbSet<DbShiftSettings> DbShiftSettings { get; set; }
        public DbSet<DbTables> DbTables { get; set; }
        public DbSet<DbTableStatuses> DbTableStatuses { get; set; }
        public DbSet<DbTaxes> DbTaxes { get; set; }
        public DbSet<DbUserPrivileges> DbUserPrivileges { get; set; }
        public DbSet<DbUsers> DbUsers { get; set; }
        public DbSet<DbUserSettings> DbUserSettings { get; set; }
        public DbSet<DbWaiters> DbWaiters { get; set; }
    }
}
