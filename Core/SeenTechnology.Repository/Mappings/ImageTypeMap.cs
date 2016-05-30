using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ImageTypeMap : ClassMap<ImageType>
    {
        public ImageTypeMap()
        {
            Table("StarW_ImageType");
            LazyLoad();
            Id(x => x.Id).Column("ImagT_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("ImagT_Description");
            HasMany(x => x.Images).KeyColumn("ImagT_Id").Inverse();
        }
    }
}
