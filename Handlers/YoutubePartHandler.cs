using CodeSanook.Youtube.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace CodeSanook.Authorization.Hanlders
{
    public class YoutubePartHandler: ContentHandler
    {
        public YoutubePartHandler(IRepository<YoutubePartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}