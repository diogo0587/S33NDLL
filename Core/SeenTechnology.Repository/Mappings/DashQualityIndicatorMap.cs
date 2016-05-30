using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DashQualityIndicatorMap : ClassMap<DashQualityIndicator>
    {
        public DashQualityIndicatorMap()
        {
            Table("StarW_DashboardQualityIndicators");
            LazyLoad();
            Id(x => x.Id).Column("DasQI_Id").GeneratedBy.Identity();
            Map(x => x.Timestamp).Column("DasQI_Timestamp");
            Map(x => x.TimeAttendanceConfig).Column("DasQI_TimeAttendanceConfig");
            Map(x => x.TimeAttendanceReal).Column("DasQI_TimeAttendanceReal");
            Map(x => x.AmountOsFinished).Column("DasQI_AmountOSFinished");
            Map(x => x.AmountIdeal).Column("DasQI_AmountIdeal");
            Map(x => x.AmountReal).Column("DasQI_AmountReal");
            References(x => x.OrderServiceType).Column("OrdST_ID");
            References(x => x.Operation).Column("Oper_Id");
        }
    }
}
