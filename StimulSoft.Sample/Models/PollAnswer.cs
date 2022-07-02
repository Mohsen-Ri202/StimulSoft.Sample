using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class PollAnswer
    {
        public PollAnswer()
        {
            PollVotingRecords = new HashSet<PollVotingRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int PollId { get; set; }
        public int NumberOfVotes { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Poll Poll { get; set; } = null!;
        public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; }
    }
}
