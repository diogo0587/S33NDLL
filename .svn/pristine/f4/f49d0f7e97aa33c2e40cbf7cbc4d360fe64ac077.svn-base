using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class NotSendServiceEventsAgainDetailMap : ClassMap<NotSendServiceEventsAgainDetail>
    {
        public NotSendServiceEventsAgainDetailMap()
        {
            Table("StarW_NotSendServiceEventsAgainDetail");
            LazyLoad();
            Id(x => x.Id).Column("NtSerEAD_Id").GeneratedBy.Identity();
            Map(x => x.FromTo).Column("NtSerEAD_FromTo");
            References(x => x.NotSendServiceEventsAgain).Column("NtSerEA_Id");
            References(x => x.ServiceEvent).Column("SerE_Id");
        }
    }
}
