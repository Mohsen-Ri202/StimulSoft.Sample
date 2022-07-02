﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class CustomerPassword
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? Password { get; set; }
        public int PasswordFormatId { get; set; }
        public string? PasswordSalt { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}