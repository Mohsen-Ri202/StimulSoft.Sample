using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class Discount
    {
        public Discount()
        {
            DiscountRequirements = new HashSet<DiscountRequirement>();
            DiscountUsageHistories = new HashSet<DiscountUsageHistory>();
            Categories = new HashSet<Category>();
            Manufacturers = new HashSet<Manufacturer>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? CouponCode { get; set; }
        public string? AdminComment { get; set; }
        public int DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? MaximumDiscountAmount { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public bool RequiresCouponCode { get; set; }
        public bool IsCumulative { get; set; }
        public int DiscountLimitationId { get; set; }
        public int LimitationTimes { get; set; }
        public int? MaximumDiscountedQuantity { get; set; }
        public bool AppliedToSubCategories { get; set; }

        public virtual ICollection<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual ICollection<DiscountUsageHistory> DiscountUsageHistories { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
