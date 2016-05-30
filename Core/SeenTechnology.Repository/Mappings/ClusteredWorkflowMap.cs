using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ClusteredWorkflowMap : ClassMap<ClusteredWorkflow>
    {
        public ClusteredWorkflowMap()
        {
            Table("StarW_ClusteredWorkflow");
            LazyLoad();
            Id(x => x.Id).Column("ClsW_Id").GeneratedBy.Identity();
            Map(x => x.Synchronized).Column("ClsW_Synchronized");
            References(x => x.OrderService).Column("OrdS_Id");
        }
    }
}
