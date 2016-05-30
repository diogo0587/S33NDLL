using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ApplicationFlowEntryPointMap : ClassMap<ApplicationFlowEntryPoint>
    {
        public ApplicationFlowEntryPointMap()
        {
            Table("StarW_ApplicationFlowEntryPoint");
            Id(c => c.Id).Column("ApFEP_Id").GeneratedBy.Identity();
            Map(c => c.Name).Column("ApFEP_Name");
            Map(c => c.AssemblyName).Column("ApFEP_AssemblyName");
            Map(c => c.AssemblyPath).Column("ApFEP_AssemblyPath");
            Map(c => c.HostName).Column("ApFEP_HostName");
        }
    }
}
