using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceLayoutMap : ClassMap<OrderServiceLayout>
    {
        public OrderServiceLayoutMap()
        {
            Table("StarW_OrderServiceLayout");
            LazyLoad();
            Id(x => x.Id).Column("OrdSL_ID").GeneratedBy.Identity();
            Map(x => x.Content).Column("OrdSL_Content");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.ServiceLayoutDetail).Column("SerLD_Id");
        }
    }
}
