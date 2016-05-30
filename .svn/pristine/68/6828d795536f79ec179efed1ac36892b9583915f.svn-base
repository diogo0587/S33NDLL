using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceTrackingMap : ClassMap<OrderServiceTracking>
    {
        public OrderServiceTrackingMap()
        {
            Table("StarW_OrderServiceTracking");
            LazyLoad();
            Id(x => x.Id).Column("OrdSTck_Id").GeneratedBy.Identity();
            Map(x => x.Reason).Column("OrdSTck_Reason");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.Account).Column("Acct_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.RouteDetail).Column("RoutD_Id");
            References(x => x.OrderServiceAttendance).Column("OsAttd_Id");
        }
    }
}
