﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class VendorAttributeValue
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int VendorAttributeId { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }

        public virtual VendorAttribute VendorAttribute { get; set; } = null!;
    }
}
