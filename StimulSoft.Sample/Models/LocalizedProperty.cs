﻿using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class LocalizedProperty
    {
        public int Id { get; set; }
        public string LocaleKeyGroup { get; set; } = null!;
        public string LocaleKey { get; set; } = null!;
        public string LocaleValue { get; set; } = null!;
        public int LanguageId { get; set; }
        public int EntityId { get; set; }

        public virtual Language Language { get; set; } = null!;
    }
}
