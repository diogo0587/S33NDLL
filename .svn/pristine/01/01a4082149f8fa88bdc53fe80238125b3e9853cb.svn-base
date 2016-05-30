using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceLayoutHeaderMap : ClassMap<ServiceLayoutHeader>
    {
        public ServiceLayoutHeaderMap()
        {
            Table("StarW_ServiceLayoutHeader");
            LazyLoad();
            Id(x => x.Id).Column("SerLH_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("SerLH_Description");
            References(x => x.ServiceTypeOrderServiceType).Column("SrOsT_Id");
            HasMany(x => x.ServiceLayoutDetails).KeyColumn("SerLH_Id").Inverse();
        }
    }
}
