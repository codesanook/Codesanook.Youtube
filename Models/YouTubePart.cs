using Orchard.ContentManagement;

namespace Codesanook.Youtube.Models {
    public class YouTubePart : ContentPart<YoutubePartRecord>
    {
        public string VideoId
        {
            get { return this.Record.VideoId; }
            set { this.Record.VideoId = value; }
        }
    }
}