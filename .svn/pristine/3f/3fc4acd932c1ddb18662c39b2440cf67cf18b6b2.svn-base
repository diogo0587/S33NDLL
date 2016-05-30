using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DashboardEventTypeMap : ClassMap<DashboardEventType>
    {
        public DashboardEventTypeMap()
        {
            Table("StarW_DashboardEventsType");
            LazyLoad();
            Id(x => x.Id).Column("DshET_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("DshET_Description");
            Map(x => x.Name).Column("DshET_Name");
            HasMany(x => x.DashboardEvents).KeyColumn("DshET_Id").Inverse();
        }
    }
}
