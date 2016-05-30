using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Table("StarW_Address");
            LazyLoad();
            Id(x => x.Id).Column("Addr_Id").GeneratedBy.Identity();
            Map(x => x.Street).Column("Addr_Street").Length(120);
            Map(x => x.Latitude).Column("Addr_Lat").Precision(53);
            Map(x => x.Longitude).Column("Addr_Lng").Precision(53);
            Map(x => x.Level).Column("Addr_Level").Precision(10);
            Map(x => x.ZipCode).Column("Addr_ZipCode").Length(9);
            Map(x => x.Neighborhood).Column("Addr_Neighborhood").Length(80);
            Map(x => x.Adjunct).Column("Addr_Adjunct").Length(150);
            Map(x => x.Complement).Column("Addr_Complement").Length(150);
            Map(x => x.Number).Column("Addr_Number").Length(20);
            References(x => x.City).Column("City_Id");
            HasMany(x => x.GroupAddressDetails).KeyColumn("Addr_Id").Inverse();
            HasMany(x => x.OrderServices).KeyColumn("Addr_Id").Inverse();
            HasMany(x => x.StartPoints).KeyColumn("Addr_Id").Inverse();
            HasMany(x => x.Technicians).KeyColumn("Addr_Id").Inverse();
        }
    }
}
