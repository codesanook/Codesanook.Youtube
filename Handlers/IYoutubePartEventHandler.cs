using Codesanook.Youtube.Models;
using Orchard.Events;

namespace Codesanook.Youtube.Handlers
{
    public interface IYoutubePartEventHandler : IEventHandler
    {
        void OnGetItemMetadata(YouTubePart youtubePart);
    }
}