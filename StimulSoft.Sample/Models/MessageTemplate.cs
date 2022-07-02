using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class MessageTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? BccEmailAddresses { get; set; }
        public string? Subject { get; set; }
        public int EmailAccountId { get; set; }
        public string? Body { get; set; }
        public bool IsActive { get; set; }
        public int? DelayBeforeSend { get; set; }
        public int DelayPeriodId { get; set; }
        public int AttachedDownloadId { get; set; }
        public bool LimitedToStores { get; set; }
    }
}
