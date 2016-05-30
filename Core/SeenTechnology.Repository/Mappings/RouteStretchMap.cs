using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RouteStretchMap : ClassMap<RouteStretch>
    {
        public RouteStretchMap()
        {
            Table("StarW_RouteStretch");
            LazyLoad();
            Id(x => x.Id).Column("RoutS_Id").GeneratedBy.Identity();
            Map(x => x.Seq).Column("RoutS_Seq");
            Map(x => x.EstimateMeter).Column("RoutS_EstimateMeter");
            Map(x => x.EstimateTime).Column("RoutS_EstimateTime");
            Map(x => x.EstimateTimeAttendance).Column("RoutS_EstimateTimeAttendance");
            Map(x => x.RouteMeter).Column("RoutS_RouteMeter");
            Map(x => x.TimeAttendance).Column("RoutS_TimeAttendance");
            Map(x => x.RouteTime).Column("RoutS_RouteTime");
            Map(x => x.Completed).Column("RoutS_Completed");
            Map(x => x.PolyTrack).Column("RoutS_PolyTrack");
            References(x => x.Route).Column("Rout_Id");
            HasMany(x => x.RouteDetails).KeyColumn("RoutS_Id").Inverse();
            HasMany(x => x.DashboardEvents).KeyColumn("RoutS_Id").Inverse();
        }
    }
}
