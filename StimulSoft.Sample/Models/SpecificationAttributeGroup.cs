using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class SpecificationAttributeGroup
    {
        public SpecificationAttributeGroup()
        {
            SpecificationAttributes = new HashSet<SpecificationAttribute>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }

        public virtual ICollection<SpecificationAttribute> SpecificationAttributes { get; set; }
    }
}
