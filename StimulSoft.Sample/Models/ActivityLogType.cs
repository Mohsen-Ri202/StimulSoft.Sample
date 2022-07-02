using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ActivityLogType
    {
        public ActivityLogType()
        {
            ActivityLogs = new HashSet<ActivityLog>();
        }

        public int Id { get; set; }
        public string SystemKeyword { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool Enabled { get; set; }

        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}
