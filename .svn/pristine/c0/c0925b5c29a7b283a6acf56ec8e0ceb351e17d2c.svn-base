using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceWorkflowMap : ClassMap<ServiceWorkflow>
    {
        public ServiceWorkflowMap()
        {
            Table("StarW_ServiceWorkflow");
            LazyLoad();
            Id(x => x.Id).Column("Wflw_ID").GeneratedBy.Identity();
            Map(x => x.ElementName).Column("Wflw_ElementName");
            Map(x => x.ContentElement).Column("Wflw_ContentElement");
            Map(x => x.LengthFieldElement).Column("Wflw_LenghtFieldElement");
            Map(x => x.RequiredElement).Column("Wflw_RequiredElement");
            Map(x => x.TypeElement).Column("Wflw_TypeElement");
            Map(x => x.TypeFieldElement).Column("Wflw_TypeFieldElement");
            Map(x => x.Score).Column("Wflw_Score");
            Map(x => x.DefaultContent).Column("Wflw_DefaultContent");
            Map(x => x.SendOnline).Column("Wflw_SendOnline");
            HasMany(x => x.OrderServiceWorkflows).KeyColumn("Wflw_ID").Inverse();
            HasMany(x => x.ServiceEventWorkflows).KeyColumn("Wflw_ID").Inverse();
            HasMany(x => x.ServiceWorkflowConfigurations).KeyColumn("Wflw_ID").Inverse();
            HasMany(x => x.ServiceWorkflowConfigurationDetails).KeyColumn("Wflw_ID").Inverse();
        }
    }
}
