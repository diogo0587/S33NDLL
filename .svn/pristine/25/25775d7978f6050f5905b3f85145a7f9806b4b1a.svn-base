using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DashboardEventMap : ClassMap<DashboardEvent>
    {
        public DashboardEventMap()
        {
            Table("StarW_DashboardEvents");
            LazyLoad();
            Id(x => x.Id).Column("DashE_Id").GeneratedBy.Identity();
            Map(x => x.Timestamp).Column("DashE_Timestamp");
            Map(x => x.Enable).Column("DashE_Enable");
            Map(x => x.Message).Column("DashE_Message");
            Map(x => x.Latitude).Column("DashE_Lat0");
            Map(x => x.Longitude).Column("DashE_Lng0");
            Map(x => x.Response).Column("DashE_Response");
            Map(x => x.ResponseDate).Column("DashE_ResponseDate");
            References(x => x.OrderService).Column("OrdS_ID");
            References(x => x.Technician).Column("Tech_Id");
            References(x => x.DashboardEventType).Column("DashET_Id");
            References(x => x.RouteStretch).Column("RoutS_Id");
            References(x => x.Route).Column("Rout_Id");
            References(x => x.RecordStatuses).Column("RecSt_Id");
            References(x => x.Account).Column("Acct_Id");
            References(x => x.Images0).Column("Imag0_Id");
            References(x => x.Images1).Column("Imag1_Id");
            HasMany(x => x.DashPerformanceIndicatorAnalytics).KeyColumn("DashE_Id").Inverse();
        }
    }
}
