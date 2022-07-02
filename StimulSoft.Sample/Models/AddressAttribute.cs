using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class AddressAttribute
    {
        public AddressAttribute()
        {
            AddressAttributeValues = new HashSet<AddressAttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<AddressAttributeValue> AddressAttributeValues { get; set; }
    }
}
