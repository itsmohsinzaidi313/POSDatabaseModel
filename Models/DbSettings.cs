using RMSEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSDatabaseModel.Models
{
    [Table("Settings")]
    public class DbSettings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DataTypeId { get; set; }
        public ValueDataType DataType
        {
            get
            {
                foreach (ValueDataType x in Enum.GetValues<ValueDataType>())
                {
                    if (DataTypeId == (int)x)
                        return x;
                }
                return ValueDataType.Undefined;
            }
        }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public DbBranch Branch { get; set; }
        public bool Truncated { get; set; }
        public List<DbSettingsDetails> Settings { get; set; }
    }
}
