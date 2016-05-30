using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceEventGroupMap : ClassMap<ServiceEventGroup>
    {
        public ServiceEventGroupMap()
        {
            Table("StarW_ServiceEventGroup");
            LazyLoad();
            Id(m => m.Id).Column("SerEG_Id").GeneratedBy.Identity();
            Map(m => m.Description).Column("SerEG_Description");
            HasMany(x => x.ServiceEvents).KeyColumn("SerEG_Id").Inverse();
        }
    }
}
