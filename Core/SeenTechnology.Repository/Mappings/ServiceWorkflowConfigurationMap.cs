using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceWorkflowConfigurationMap : ClassMap<ServiceWorkflowConfiguration>
    {
        public ServiceWorkflowConfigurationMap()
        {
            Table("StarW_ServiceWorkflowConfig");
            LazyLoad();
            Id(x => x.Id).Column("WflwCfg_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("WflwCfg_Description");
            Map(x => x.SendOnline).Column("WflwCfg_SendOnline");
            Map(x => x.FromTo).Column("WflwCfg_FromTo");
            References(x => x.Operation).Column("Oper_Id").Cascade.None();
            References(x => x.ServiceWorkflow).Column("Wflw_ID").Cascade.None();
            References(x => x.ServiceWorkflowConfigurationDetail).Column("WflwCfgD_Id").Cascade.None();
            HasMany(x => x.ServiceWorkflowConfigurationQuestionnaries).KeyColumn("WflwCfg_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflows).KeyColumn("WflwCfg_Id").Inverse();
            HasMany(x => x.ServiceEventWorkflows).KeyColumn("WflwCfg_Id").Inverse();
        }
    }
}
