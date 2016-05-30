using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ComponentModelMap : ClassMap<ComponentModel>
    {
        public ComponentModelMap()
        {
            Table("StarW_ComponentModel");
            LazyLoad();
            Id(m => m.Id).Column("CompM_Id").GeneratedBy.Identity();
            Map(m => m.Description).Column("CompM_Description");
            Map(m => m.ExternalId).Column("CompM_ExternalId");
            HasMany(x => x.Components).KeyColumn("CompM_Id").Inverse();
            HasMany(x => x.OrderServiceDetailComponents).KeyColumn("CompM_Id").Inverse();
        }
    }
}
