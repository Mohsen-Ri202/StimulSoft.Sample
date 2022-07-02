using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ReviewType
    {
        public ReviewType()
        {
            ProductReviewReviewTypeMappings = new HashSet<ProductReviewReviewTypeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public bool VisibleToAllCustomers { get; set; }
        public bool IsRequired { get; set; }

        public virtual ICollection<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
    }
}
