using RMSEnumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("UserPrivileges")]
    public class DbUserPrivileges
    {
        public int Id { get; set; }
        public string PrivilegeName { get; set; }
        [NotMapped]
        public UserPrivilege Privilege
        {
            get
            {
                foreach (UserPrivilege x in new List<UserPrivilege> { UserPrivilege.Administrator, UserPrivilege.BranchManager, UserPrivilege.Manager, UserPrivilege.OperationsManager, UserPrivilege.Cashier })
                {
                    if (Id == (int)x)
                        return x;
                }
                return UserPrivilege.Undefined;
            }
        }
        public bool Truncated { get; set; }
    }
}
