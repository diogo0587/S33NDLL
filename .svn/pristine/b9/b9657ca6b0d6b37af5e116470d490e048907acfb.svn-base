using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowMap : ClassMap<OrderServiceWorkflow>
    {
        public OrderServiceWorkflowMap()
        {
            Table("StarW_OrderServiceWorkflow");
            LazyLoad();
            Id(m => m.Id).Column("OrdSW_Id").GeneratedBy.Identity();
            Map(x => x.ElementName).Column("OrdSW_ElementName");
            Map(x => x.ContentElement).Column("OrdSW_ContentElement");
            Map(x => x.LenghtFieldElement).Column("OrdSW_LenghtFieldElement");
            Map(x => x.RequiredElement).Column("OrdSW_RequiredElement");
            Map(x => x.TypeElement).Column("OrdSW_TypeElement");
            Map(x => x.TypeFieldElement).Column("OrdSW_TypeFieldElement");
            Map(x => x.DefaultContent).Column("OrdSW_DefaultContent");
            Map(x => x.Situation).Column("OrdSW_Situation");
            References(x => x.ServiceWorkflowConfiguration).Column("WflwCfg_Id");
            References(x => x.ServiceWorkflow).Column("Wflw_ID");
            References(x => x.OrderServiceAttendance).Column("OsAttd_Id");
            HasMany(x => x.OrderServiceWorkflowQuestionResponses).KeyColumn("OrdSWP_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowProducts).KeyColumn("OrdSW_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowDetails).KeyColumn("OrdSWH_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowTokens).KeyColumn("OrdSWH_Id").Inverse();
        }
    }
}
