using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class VendorActivationInfo
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public DateTime? ActivationDate { get; set; }
    }
}
