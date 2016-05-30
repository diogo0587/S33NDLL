using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RouteDetailMap : ClassMap<RouteDetail>
    {
        public RouteDetailMap()
        {
            Table("StarW_RouteDetail");
            LazyLoad();
            Id(x => x.Id).Column("RoutD_Id").GeneratedBy.Identity();
            Map(x => x.Enable).Column("RoutD_Enable");
            Map(x => x.LastUpdate).Column("RoutD_LastUpdate");
            Map(x => x.DatetimeStart).Column("RoutD_DatetimeStart");
            Map(x => x.DatetimeEnd).Column("RoutD_DatetimeCompleted");
            Map(x => x.IsNext).Column("RoutD_IsNext");
            Map(x => x.Reason).Column("RoutD_Reason");
            References(x => x.ServiceEvent).Column("SerE_Id");
            References(x => x.OrderService).Column("OrdS_ID");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.OrderServiceAttendance).Column("OsAttd_Id");
            References(x => x.RouteStretch).Column("RoutS_Id");
            HasMany(x => x.NotifyOrderServices).KeyColumn("RoutD_Id").Inverse();
            HasMany(x => x.OrderServiceAttendances).KeyColumn("RoutD_Id").Inverse();
            HasMany(x => x.OrderServiceStatuses).KeyColumn("RoutD_Id").Inverse();
            HasMany(x => x.OrderServiceTrackings).KeyColumn("RoutD_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflows).KeyColumn("RoutD_Id").Inverse();
        }
    }
}
