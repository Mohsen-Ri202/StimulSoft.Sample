using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            Countries = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
