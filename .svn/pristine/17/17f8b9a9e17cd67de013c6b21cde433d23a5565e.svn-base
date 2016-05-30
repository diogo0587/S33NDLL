using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceEventTypeMap : ClassMap<ServiceEventType>
    {
        public ServiceEventTypeMap()
        {
            Table("StarW_ServiceEventType");
            LazyLoad();
            Id(m => m.Id).Column("SerET_Id").GeneratedBy.Increment();
            Map(m => m.Description).Column("SerET_Description");
            HasMany(x => x.ServiceEvents).KeyColumn("SerET_Id").Inverse();
        }
    }
}
