using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ClusteredWorkflowDetailMap : ClassMap<ClusteredWorkflowDetail>
    {
        public ClusteredWorkflowDetailMap()
        {
            Table("StarW_ClusteredWorkflowDetail");
            LazyLoad();
            Id(x => x.Id).Column("ClsWD_Id").GeneratedBy.Identity();
            Map(x => x.Processed).Column("ClsWD_Processed");
            Map(x => x.Synchronized).Column("ClsWD_Synchronized");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.ClusteredWorkflow).Column("ClsW_Id");
        }
    }
}
