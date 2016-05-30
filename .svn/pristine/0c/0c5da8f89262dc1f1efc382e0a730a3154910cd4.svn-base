using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowProductComponentMap : ClassMap<OrderServiceWorkflowProductComponent>
    {
        public OrderServiceWorkflowProductComponentMap()
        {
            Table("StarW_OrderServiceWorkflowXProdXComp");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWPC_Id").GeneratedBy.Identity();
            References(x => x.Component).Column("Comp_Id");
            References(x => x.OrderServiceWorkflowProduct).Column("OrdSWP_Id");
        }
    }
}
