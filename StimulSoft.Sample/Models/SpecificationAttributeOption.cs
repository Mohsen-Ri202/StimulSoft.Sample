using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class SpecificationAttributeOption
    {
        public SpecificationAttributeOption()
        {
            ProductSpecificationAttributeMappings = new HashSet<ProductSpecificationAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ColorSquaresRgb { get; set; }
        public int SpecificationAttributeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual SpecificationAttribute SpecificationAttribute { get; set; } = null!;
        public virtual ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
    }
}
