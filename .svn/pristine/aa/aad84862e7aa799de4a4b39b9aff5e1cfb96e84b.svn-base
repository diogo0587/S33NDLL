using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceWorkflowConfigurationQuestionnarieMap : ClassMap<ServiceWorkflowConfigurationQuestionnarie>
    {
        public ServiceWorkflowConfigurationQuestionnarieMap()
        {
            Table("StarW_ServiceWorkflowfConfigXQuestionnarie");
            LazyLoad();
            Id(c => c.Id).Column("WflwCQ_Id").GeneratedBy.Identity();
            References(c => c.Questionnarie).Column("Qstn_Id");
            References(x => x.ServiceWorkflowConfiguration).Column("WflwCfg_Id");
        }
    }
}
