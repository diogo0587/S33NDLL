using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RouteMap : ClassMap<Route>
    {
        public RouteMap()
        {
            Table("StarW_Route");
            LazyLoad();
            Id(m => m.Id).Column("Rout_Id").GeneratedBy.Identity();
            Map(m => m.SessionClusterize).Column("Rout_SessionClusterize");
            Map(m => m.Auxiliary1).Column("Rout_Auxiliary1");
            Map(m => m.Auxiliary2).Column("Rout_Auxiliary2");
            Map(m => m.Auxiliary3).Column("Rout_Auxiliary3");
            Map(m => m.Auxiliary4).Column("Rout_Auxiliary4");
            Map(m => m.Auxiliary5).Column("Rout_Auxiliary5");
            Map(m => m.Enable).Column("Rout_Enable");
            Map(m => m.Start).Column("Rout_Start");
            Map(m => m.Finished).Column("Rout_Finished");
            Map(m => m.Received).Column("Rout_Received");
            References(x => x.StartPointOperation).Column("StpxOp_Id");
            References(x => x.Technician).Column("Tech_Id");
            References(x => x.MobileDevice).Column("MobD_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            HasMany(x => x.RouteStretches).KeyColumn("Rout_Id").Inverse();
            HasMany(x => x.RouteDeliveries).KeyColumn("Rout_Id").Inverse();
            HasMany(x => x.RouteComponents).KeyColumn("Rout_Id").Inverse();
            HasMany(x => x.RouteProducts).KeyColumn("Rout_Id").Inverse();
            HasMany(x => x.DashboardEvents).KeyColumn("Rout_Id").Inverse();
            HasMany(x => x.RequestTrackingDetail).KeyColumn("Rout_Id").Inverse();
        }
    }
}
