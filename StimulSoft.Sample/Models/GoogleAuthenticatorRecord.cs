using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class GoogleAuthenticatorRecord
    {
        public int Id { get; set; }
        public string? Customer { get; set; }
        public string? SecretKey { get; set; }
    }
}
