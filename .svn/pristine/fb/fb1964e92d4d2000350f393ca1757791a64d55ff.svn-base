using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceStatusMap : ClassMap<OrderServiceStatus>
    {
        public OrderServiceStatusMap()
        {
            Table("StarW_OrderServiceStatus");
            LazyLoad();
            Id(x => x.Id).Column("OrdSSt_Id").GeneratedBy.Identity();
            Map(x => x.DateReceiving).Column("OrdSSt_DateReceiving");
            Map(x => x.DateSynchronization).Column("OrdSSt_DateSynchronization");
            Map(x => x.DateOut).Column("OrdSSt_DateOut");
            References(x => x.RouteDetail).Column("RoutD_Id");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.OrderServiceAttendance).Column("OsAttd_Id");
        }
    }
}
