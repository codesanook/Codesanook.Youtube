using CodeSanook.Youtube.Handlers;
using CodeSanook.Youtube.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace CodeSanook.Authorization.Hanlders
{
    public class YoutubePartHandler: ContentHandler
    {
        private readonly IYoutubePartEventHandler youtubePartEventHandler;

        public YoutubePartHandler(IRepository<YoutubePartRecord> repository, IYoutubePartEventHandler youtubePartEventHandler)
        {
            Filters.Add(StorageFilter.For(repository));
            this.youtubePartEventHandler = youtubePartEventHandler;
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            var isHomePage = context.ContentItem.ContentType == "HomePage";
            if (!isHomePage) return;

            var youtubePart = context.ContentItem.As<YouTubePart>();
            youtubePartEventHandler.OnGetItemMetadata(youtubePart);
        }
    }
}