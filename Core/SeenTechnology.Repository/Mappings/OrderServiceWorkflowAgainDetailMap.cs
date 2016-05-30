using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowAgainDetailMap : ClassMap<OrderServiceWorkflowAgainDetail>
    {
        public OrderServiceWorkflowAgainDetailMap()
        {
            Table("StarW_OrderServiceWorkflowAgainDetail");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWAD_Id").GeneratedBy.Identity();
            Map(x => x.ExternalId).Column("OrdSWAD_ExternalId");
            Map(x => x.Note).Column("OrdSWAD_Note");
            References(x => x.OrderServiceWorkFlowAgain).Column("OrdSWA_Id");
        }
    }
}
