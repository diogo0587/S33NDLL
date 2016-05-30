using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceEventWorkflowMap : ClassMap<ServiceEventWorkflow>
    {
        public ServiceEventWorkflowMap()
        {
            Table("StarW_ServiceEventWorkflows");
            LazyLoad();
            Id(x => x.Id).Column("SerEW_ID").GeneratedBy.Identity();
            Map(x => x.Sequence).Column("SerEW_Sequence");
            Map(x => x.DefaultContent).Column("SerEW_DefaultContent");
            Map(x => x.LenghtFieldElement).Column("SerEW_LenghtFieldElement");
            Map(x => x.RequiredElement).Column("SerEW_RequiredElement");
            Map(x => x.SendOnline).Column("SerEW_SendOnline");
            Map(x => x.Score).Column("SerEW_Core");
            Map(x => x.Enable).Column("SerEW_Enable");
            References(x => x.ServiceWorkflowConfiguration).Column("WflwCfg_ID");
        }
    }
}
