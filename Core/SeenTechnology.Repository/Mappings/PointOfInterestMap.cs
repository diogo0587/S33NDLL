using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class PointOfInterestMap : ClassMap<PointOfInterest>
    {
        public PointOfInterestMap()
        {
            Table("StarW_PointOfInterest");
            LazyLoad();
            Id(x => x.Id).Column("PoI_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("PoI_Description");
            Map(x => x.Latitude).Column("PoI_Latitude");
            Map(x => x.Longitude).Column("PoI_Longitude");
        }
    }
}
