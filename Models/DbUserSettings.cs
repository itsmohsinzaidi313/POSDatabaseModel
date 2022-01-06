using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    public class DbUserSettings
    {
        public int Id { get; set; }
        [NotMapped]
        public UserPrivilege Privilege
        {
            get
            {
                foreach (UserPrivilege x in new List<UserPrivilege> { UserPrivilege.Administrator, UserPrivilege.BranchManager, UserPrivilege.Manager, UserPrivilege.OperationsManager, UserPrivilege.Cashier })
                {
                    if (PrivilageId == (int)x)
                        return x;
                }
                return UserPrivilege.Undefined;
            }
            set
            {
                PrivilageId = (int)value;
            }
        }
        public int PrivilageId { get; set; }
        public DbUserPrivileges Privileges { get; set; }
        public bool Enabled { get; set; }
        public bool Truncated { get; set; }
    }
}
