using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ComponentMap : ClassMap<Component>
    {
        public ComponentMap()
        {
            Table("StarW_Component");
            LazyLoad();
            Id(x => x.Id).Column("Comp_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("Comp_Description");
            Map(x => x.SerialNumber).Column("Comp_SerialNumber");
            Map(x => x.Protocol).Column("Comp_Protocol");
            Map(x => x.ExternalId).Column("Comp_ExternalId");
            References(x => x.ComponentType).Column("CompT_Id");
            References(x => x.ComponentModel).Column("CompM_Id");
            References(x => x.Operation).Column("Oper_Id");
            HasMany(x => x.OrderServiceDetail).KeyColumn("Comp_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowProductComponent).KeyColumn("Comp_Id").Inverse();
            HasMany(x => x.ProductComponent).KeyColumn("Comp_Id").Inverse();
            HasMany(x => x.RouteComponent).KeyColumn("Comp_Id").Inverse();
        }
    }
}
