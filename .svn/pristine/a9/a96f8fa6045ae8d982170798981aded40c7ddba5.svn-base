using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceExportCteDetailMap : ClassMap<OrderServiceExportCteDetail>
    {
        public OrderServiceExportCteDetailMap()
        {
            Table("StarW_OrderServiceExportCteDetail");
            LazyLoad();
            Id(x => x.Id).Column("OrdSECD_Id").GeneratedBy.Identity();
            References(x => x.OrderService).Column("OrdS_ID");
        }
    }
}
