using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowTokenMap : ClassMap<OrderServiceWorkflowToken>
    {
        public OrderServiceWorkflowTokenMap()
        {
            Table("StarW_OrderServiceWorkflowToken");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWTk_Id").GeneratedBy.Identity();
            Map(x => x.Key).Column("OrdSWTk_Key");
            References(x => x.OrderServiceWorkflow).Column("OrdSW_Id");
            References(x => x.OrderService).Column("OrdS_Id");
        }
    }
}
