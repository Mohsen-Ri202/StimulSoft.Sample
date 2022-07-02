using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            PredefinedProductAttributeValues = new HashSet<PredefinedProductAttributeValue>();
            ProductProductAttributeMappings = new HashSet<ProductProductAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual ICollection<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
    }
}
