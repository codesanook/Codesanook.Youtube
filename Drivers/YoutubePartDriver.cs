using Codesanook.Youtube.Models;
using Orchard.ContentManagement.Drivers;

namespace Codesanook.Youtube.Drivers
{
    public class YoutubePartDriver : ContentPartDriver<YouTubePart>
    {
        protected override DriverResult Display(
            YouTubePart part,
            string displayType,
            dynamic shapeHelper)
        {
            return
                ContentShape(
                    "Parts_Youtube",
                    () => shapeHelper.Parts_Youtube(
                        VideoId : part.VideoId
                    )
                );
        }
    }
}