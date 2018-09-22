using CodeSanook.Youtube.Models;
using Orchard.ContentManagement.Drivers;

namespace CaptureTheFracture.Web.Drivers
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