using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codesanook.Youtube.Models
{
    public class YouTubePart : ContentPart<YoutubePartRecord>
    {
        public int Id
        {
            get { return this.Record.Id; }
            set { this.Record.Id = value; }
        }
        public string VideoId
        {
            get { return this.Record.VideoId; }
            set { this.Record.VideoId = value; }
        }
    }
}