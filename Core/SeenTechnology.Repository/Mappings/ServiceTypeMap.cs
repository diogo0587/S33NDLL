using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceTypeMap : ClassMap<ServiceType>
    {
        public ServiceTypeMap()
        {
            Table("StarW_ServiceType");
            LazyLoad();
            Id(x => x.Id).Column("SerT_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("SerT_Description");
            HasMany(x => x.OperationServiceTypes).KeyColumn("SerT_Id").Inverse();
        }
    }
}
