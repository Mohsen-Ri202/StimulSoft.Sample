﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ProductReview
    {
        public ProductReview()
        {
            ProductReviewHelpfulnesses = new HashSet<ProductReviewHelpfulness>();
            ProductReviewReviewTypeMappings = new HashSet<ProductReviewReviewTypeMapping>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public bool IsApproved { get; set; }
        public string? Title { get; set; }
        public string? ReviewText { get; set; }
        public string? ReplyText { get; set; }
        public bool CustomerNotifiedOfReply { get; set; }
        public int Rating { get; set; }
        public int HelpfulYesTotal { get; set; }
        public int HelpfulNoTotal { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual ICollection<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
    }
}
