using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceDetailComponentMap : ClassMap<OrderServiceDetailComponent>
    {
        public OrderServiceDetailComponentMap()
        {
            Table("StarW_OrderServiceDetailComponent");
            LazyLoad();
            Id(x => x.Id).Column("OrdSDC_Id").GeneratedBy.Identity();
            Map(x => x.Quantity).Column("OrdSDC_Quantity");
            Map(x => x.Optional).Column("OrdSDC_Optional");
            References(x => x.Component).Column("Comp_Id");
            References(x => x.ComponentType).Column("CompT_Id");
            References(x => x.ComponentModel).Column("CompM_Id");
        }
    }
}
