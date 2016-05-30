using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RouteDeliveryMap : ClassMap<RouteDelivery>
    {
        public RouteDeliveryMap()
        {
            Table("StarW_RouteDelivery");
            LazyLoad();
            Id(x => x.Id).Column("RoutDv_Id").GeneratedBy.Identity();
            Map(x => x.StartNotAfter).Column("RoutDv_StartNotAfter");
            Map(x => x.StartNotBefore).Column("RoutDv_StartNotBefore");
            References(x => x.Route).Column("Rout_Id");
        }
    }
}
