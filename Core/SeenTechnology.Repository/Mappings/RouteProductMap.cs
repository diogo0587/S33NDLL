using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RouteProductMap : ClassMap<RouteProduct>
    {
        public RouteProductMap()
        {
            Table("StarW_RouteProduct");
            LazyLoad();
            Id(x => x.Id).Column("RoutP_Id").GeneratedBy.Identity();
            References(x => x.Product).Column("Prod_Id");
            References(x => x.Route).Column("Rout_Id");
        }
    }
}
