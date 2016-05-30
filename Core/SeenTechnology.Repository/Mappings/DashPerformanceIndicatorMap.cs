using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DashPerformanceIndicatorMap : ClassMap<DashPerformanceIndicator>
    {
        public DashPerformanceIndicatorMap()
        {
            Table("StarW_DashboardPerformanceIndicators");
            LazyLoad();
            Id(x => x.Id).Column("DasPI_Id").GeneratedBy.Identity();
            Map(x => x.Timestamp).Column("DasPI_Timestamp");
            Map(x => x.Type).Column("DasPI_Type");
            Map(x => x.Percent).Column("DasPI_Percent");
            Map(x => x.AmountOSX).Column("DasPI_AmountOSX");
            Map(x => x.AmountOSY).Column("DasPI_AmountOSY");
            References(x => x.Operation).Column("Oper_Id");
        }
    }
}
