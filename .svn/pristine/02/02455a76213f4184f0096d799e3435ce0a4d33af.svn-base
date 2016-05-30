using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DashPerformanceIndicatorAnalyticMap : ClassMap<DashPerformanceIndicatorAnalytic>
    {
        public DashPerformanceIndicatorAnalyticMap()
        {
            Table("StarW_DashboardPerfIndicAnalytic");
            LazyLoad();
            Id(x => x.Id).Column("DshPIA_Id").GeneratedBy.Identity();
            Map(x => x.TimeStamp).Column("DshPIA_TimeStamp");
            References(x => x.DashboardEvent).Column("DashE_Id");
        }
    }
}
