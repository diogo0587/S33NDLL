using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Table("StarW_City");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("City_Id");
            Map(x => x.Name).Column("City_Name");
            Map(x => x.State).Column("City_State");
            Map(x => x.ZipCode0).Column("City_ZipCode0");
            Map(x => x.ZipCode1).Column("City_ZipCode1");
            Map(x => x.Latitude0).Column("City_Lat0");
            Map(x => x.Latitude1).Column("City_Lat1");
            Map(x => x.Longitude0).Column("City_Lng0");
            Map(x => x.Longitude1).Column("City_Lng1");
            Map(x => x.NameGoogle).Column("City_NameGoogle");
            Map(x => x.Latitude).Column("City_Lat");
            Map(x => x.Longitude).Column("City_Lng");
            HasMany(x => x.Addresses).KeyColumn("City_Id").Inverse();
        }
    }
}
