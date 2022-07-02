using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class CustomerRole
    {
        public CustomerRole()
        {
            AclRecords = new HashSet<AclRecord>();
            TierPrices = new HashSet<TierPrice>();
            Customers = new HashSet<Customer>();
            PermissionRecords = new HashSet<PermissionRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? SystemName { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public bool EnablePasswordLifetime { get; set; }
        public bool OverrideTaxDisplayType { get; set; }
        public int DefaultTaxDisplayTypeId { get; set; }
        public int PurchasedWithProductId { get; set; }

        public virtual ICollection<AclRecord> AclRecords { get; set; }
        public virtual ICollection<TierPrice> TierPrices { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PermissionRecord> PermissionRecords { get; set; }
    }
}
