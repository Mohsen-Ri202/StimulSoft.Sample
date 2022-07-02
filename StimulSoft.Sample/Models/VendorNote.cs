using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class VendorNote
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int VendorId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Vendor Vendor { get; set; } = null!;
    }
}
