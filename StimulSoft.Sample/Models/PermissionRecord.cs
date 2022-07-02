using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class PermissionRecord
    {
        public PermissionRecord()
        {
            CustomerRoles = new HashSet<CustomerRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SystemName { get; set; } = null!;
        public string Category { get; set; } = null!;

        public virtual ICollection<CustomerRole> CustomerRoles { get; set; }
    }
}
