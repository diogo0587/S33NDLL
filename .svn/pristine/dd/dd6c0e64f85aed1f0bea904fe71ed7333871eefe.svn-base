using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RouteComponentMap : ClassMap<RouteComponent>
    {
        public RouteComponentMap()
        {
            Table("StarW_RouteComponent");
            Id(m => m.Id).Column("RoutC_Id").GeneratedBy.Identity();
            References(x => x.Component).Column("Comp_Id");
            References(x => x.Route).Column("Rout_Id");
        }
    }
}
