using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class ForumsPost
    {
        public ForumsPost()
        {
            ForumsPostVotes = new HashSet<ForumsPostVote>();
        }

        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public string? Ipaddress { get; set; }
        public int CustomerId { get; set; }
        public int TopicId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int VoteCount { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ForumsTopic Topic { get; set; } = null!;
        public virtual ICollection<ForumsPostVote> ForumsPostVotes { get; set; }
    }
}
