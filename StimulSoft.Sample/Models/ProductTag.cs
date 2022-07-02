using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ProductTag
    {
        public ProductTag()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
