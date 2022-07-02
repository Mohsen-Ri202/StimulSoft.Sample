﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class Poll
    {
        public Poll()
        {
            PollAnswers = new HashSet<PollAnswer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int LanguageId { get; set; }
        public string? SystemKeyword { get; set; }
        public bool Published { get; set; }
        public bool ShowOnHomepage { get; set; }
        public bool AllowGuestsToVote { get; set; }
        public int DisplayOrder { get; set; }
        public bool LimitedToStores { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }

        public virtual Language Language { get; set; } = null!;
        public virtual ICollection<PollAnswer> PollAnswers { get; set; }
    }
}
