﻿using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codesanook.Youtube.Models
{
    public class YoutubePartRecord:ContentPartRecord
    {
        public virtual string VideoId { get; set; }
    }
}