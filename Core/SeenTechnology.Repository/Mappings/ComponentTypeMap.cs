using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ComponentTypeMap : ClassMap<ComponentType>
    {
        public ComponentTypeMap()
        {
            Table("StarW_ComponentType");
            LazyLoad();
            Id(m => m.Id).Column("CompT_Id").GeneratedBy.Identity();
            Map(m => m.Description).Column("CompT_Description");
            Map(m => m.ExternalId).Column("CompT_ExternalId");
            HasMany(x => x.Components).KeyColumn("CompT_Id").Inverse();
            HasMany(x => x.OrderServiceDetailComponents).KeyColumn("CompT_Id").Inverse();
        }
    }
}
