using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowDetailMap : ClassMap<OrderServiceWorkflowDetail>
    {
        public OrderServiceWorkflowDetailMap()
        {
            Table("StarW_OrderServiceWorkflowDetail");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWD_Id").GeneratedBy.Identity();
            References(x => x.OrderServiceWorkflow).Column("OrdSW_Id");
        }
    }
}
