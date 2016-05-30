using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertAlternativeServiceEventMap : ClassMap<AlertAlternativeServiceEvent>
    {
        public AlertAlternativeServiceEventMap()
        {
            Table("StarW_AlertXAlternativeXEvent");
            LazyLoad();
            Id(x => x.Id).Column("AltAE_Id").GeneratedBy.Identity();
            References(x => x.Alternative).Column("Alt_Id");
            References(x => x.AlertDetail).Column("AlrtD_Id");
            References(x => x.ServiceEvent).Column("SerE_Id");
        }
    }
}
