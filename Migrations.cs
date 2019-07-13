using Codesanook.Youtube.Models;
using Orchard.Data.Migration;
using Codesanook.Common.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Codesanook.Youtube.Handlers;

namespace Codesanook.Youtube
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable<YoutubePartRecord>(tableConfig => tableConfig
               .ContentPartRecord()
               .Column<YoutubePartRecord, string>(table => table.VideoId)
            );

            //create Youtube part
            ContentDefinitionManager.AlterPartDefinition(nameof(YouTubePart),
                cfg => cfg.Attachable(true));
            return 1;
        }
    }
}