using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceTypeOrderServiceTypeMap : ClassMap<ServiceTypeOrderServiceType>
    {
        public ServiceTypeOrderServiceTypeMap()
        {
            Table("StarW_ServTpXOSTp");
            LazyLoad();
            Id(x => x.Id).Column("SrOsT_Id").GeneratedBy.Identity();
            Map(x => x.Reference).Column("SrOsT_Reference");
            References(x => x.OrderServiceType).Column("OrdST_ID");
            HasMany(x => x.ServiceEvents).KeyColumn("SrOsT_Id").Inverse();
            HasMany(x => x.ServiceLayoutHeaders).KeyColumn("SrOsT_Id").Inverse();
        }
    }
}
