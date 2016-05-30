using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkFlowAgainMap : ClassMap<OrderServiceWorkFlowAgain>
    {
        public OrderServiceWorkFlowAgainMap()
        {
            Table("StarW_OrderServiceWorkflowAgain");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWA_Id").GeneratedBy.Identity();
            Map(x => x.Proccessed).Column("OrdSWA_Proccessed");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            HasMany(x => x.OrderServiceWorkflowAgainDetails).KeyColumn("OrdSWA_Id").Inverse();
        }
    }
}
