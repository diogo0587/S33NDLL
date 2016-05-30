using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class GpsPositionMap : ClassMap<GpsPosition>
    {
        public GpsPositionMap()
        {
            Table("StarW_GpsPosition");
            LazyLoad();
            Id(x => x.Id).Column("GpsP_Id").GeneratedBy.Identity();
            Map(x => x.Latitude).Column("GpsP_Lat");
            Map(x => x.Longitude).Column("GpsP_Lng");
            Map(x => x.Timestamp).Column("GpsP_Timestamp");
            Map(x => x.TimeZone).Column("GpsP_TimeZone");
            Map(x => x.Auxiliary1).Column("GpsP_Auxiliary1");
            Map(x => x.Auxiliary2).Column("GpsP_Auxiliary2");
            References(x => x.Device).Column("MobD_Id");
            References(x => x.Techinician).Column("Tech_Id");
            HasMany(x => x.OrderServiceWorkflows).KeyColumn("GpsP_Id");
        }
    }
}
