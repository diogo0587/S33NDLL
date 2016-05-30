using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceWorkflowConfigurationDetailMap : ClassMap<ServiceWorkflowConfigurationDetail>
    {
        public ServiceWorkflowConfigurationDetailMap()
        {
            Table("StarW_ServiceWorkflowConfigDetail");
            LazyLoad();
            Id(c => c.Id).Column("WflwCfgD_Id").GeneratedBy.Identity();
            References(c => c.ServiceWorkflow).Column("Wflw_ID");
        }
    }
}
