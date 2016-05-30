using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class StartPointMap : ClassMap<StartPoint>
    {
        public StartPointMap()
        {
            Table("StarW_StartPoint");
            LazyLoad();
            Id(x => x.Id).Column("StrP_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("StrP_Description");
            Map(x => x.Auxiliary1).Column("StrP_Auxiliary1");
            Map(x => x.Auxiliary2).Column("StrP_Auxiliary2");
            Map(x => x.Auxiliary3).Column("StrP_Auxiliary3");
            Map(x => x.Auxiliary4).Column("StrP_Auxiliary4");
            Map(x => x.Auxiliary5).Column("StrP_Auxiliary5");
            References(x => x.Customer).Column("Cust_Id").Cascade.None();
            References(x => x.Address).Column("Addr_Id").Cascade.None();
            HasMany(x => x.MobileDevices).KeyColumn("StrP_Id").Inverse();
            HasMany(x => x.StartPointOperations).KeyColumn("StrP_Id").Inverse();
            HasMany(x => x.Technicians).KeyColumn("StrP_Id").Inverse();
        }
    }
}
