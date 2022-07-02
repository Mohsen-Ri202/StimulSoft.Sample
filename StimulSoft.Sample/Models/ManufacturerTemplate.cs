﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ManufacturerTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ViewPath { get; set; } = null!;
        public int DisplayOrder { get; set; }
    }
}