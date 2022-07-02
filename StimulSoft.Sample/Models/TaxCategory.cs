﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class TaxCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }
    }
}
