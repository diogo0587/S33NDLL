using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertMap : ClassMap<Alert>
    {
        public AlertMap()
        {
            Table("StarW_Alert");
            LazyLoad();
            Id(x => x.Id).Column("Alrt_Id").GeneratedBy.Identity();
            Map(x => x.ProcessName).Column("Alrt_ProcessName");
            References(x => x.AlertType).Column("AlrtT_Id");
            HasMany(x => x.AlertDetails).KeyColumn("Alrt_Id").Inverse();
        }
    }
}
