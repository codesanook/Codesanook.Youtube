using CodeSanook.Youtube.Models;
using Orchard.Events;

namespace CodeSanook.Youtube.Handlers
{
    public interface IYoutubePartEventHandler : IEventHandler
    {
        void OnGetItemMetadata(YouTubePart youtubePart);
    }
}