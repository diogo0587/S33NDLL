using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class NotifyOrderServiceMap : ClassMap<NotifyOrderService>
    {
        public NotifyOrderServiceMap()
        {
            Table("StarW_NotifyOrderService");
            LazyLoad();
            Id(x => x.Id).Column("NtfOs_Id").GeneratedBy.Identity();
            Map(x => x.LastUpdate).Column("NtfOs_LastUpdate");
            Map(x => x.TransportMode).Column("NtfOs_TransportMode");
            Map(x => x.Reason).Column("NtfOs_Reason");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.RouteDetail).Column("RoutD_Id");
        }
    }
}
