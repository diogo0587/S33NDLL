using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DashSafetyIndicatorMap : ClassMap<DashSafetyIndicator>
    {
        public DashSafetyIndicatorMap()
        {
            Table("StarW_DashboardSafetyIndicators");
            LazyLoad();
            Id(x => x.Id).Column("DasSI_Id").GeneratedBy.Identity();
            Map(x => x.Timestamp).Column("DasSI_Timestamp");
            Map(x => x.AmountOS).Column("DasSI_AmountOS");
            Map(x => x.AmountOSWithAlarm).Column("DasSI_AmountOSWithAlarm");
            References(x => x.Operation).Column("Oper_Id");
        }
    }
}
