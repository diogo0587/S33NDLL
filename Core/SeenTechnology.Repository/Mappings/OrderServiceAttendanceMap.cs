using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceAttendanceMap : ClassMap<OrderServiceAttendance>
    {
        public OrderServiceAttendanceMap()
        {
            Table("StarW_OrderServiceAttendance");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("OsAttd_Id");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.ServiceEvent).Column("SerE_Id");
            References(x => x.RouteDetail).Column("RoutD_Id");
            References(x => x.Technician).Column("Tech_Id");
            Map(x => x.DateTimeStart).Column("OsAttd_DatetimeStart");
            Map(x => x.DateTimeCompleted).Column("OsAttd_DatetimeCompleted");
            Map(x => x.Latitude).Column("OsAttd_Lat");
            Map(x => x.Longitude).Column("OsAttd_Lng");
            Map(x => x.Key).Column("OsAttd_Key");
            HasMany(x => x.OrderServiceStatuses).KeyColumn("OsAttd_Id").Inverse();
            HasMany(x => x.OrderServiceTrackings).KeyColumn("OsAttd_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflows).KeyColumn("OsAttd_Id").Inverse();
            HasMany(x => x.RouteDetails).KeyColumn("OsAttd_Id").Inverse();
            HasMany(x => x.SendWorkflowToCustomers).KeyColumn("OsAttd_Id").Inverse();
        }
    }
}
