using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ApplicationFlowSetupDetailMap : ClassMap<ApplicationFlowSetupDetail>
    {
        public ApplicationFlowSetupDetailMap()
        {
            Table("StarW_ApplicationFlowSetupDetail");
            LazyLoad();
            Id(c => c.Id).Column("AppFSD_Id").GeneratedBy.Identity();
            Map(c => c.UpdateOrderServiceStatus).Column("AppFSD_UpdStatusOS");
            Map(c => c.UpdateOrderServiceTracking).Column("AppFSD_UpdTrackingOS");
            References(c => c.RecordStatusFrom).Column("FromRecSt_Id");
            References(c => c.RecordStatusTo).Column("ToRecSt_Id");
            References(x => x.ApplicationFlowSetup).Column("AppFS_Id");
        }
    }
}
