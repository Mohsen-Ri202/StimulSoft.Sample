using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class EmailAccount
    {
        public EmailAccount()
        {
            QueuedEmails = new HashSet<QueuedEmail>();
        }

        public int Id { get; set; }
        public string? DisplayName { get; set; }
        public string Email { get; set; } = null!;
        public string Host { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public bool UseDefaultCredentials { get; set; }

        public virtual ICollection<QueuedEmail> QueuedEmails { get; set; }
    }
}
