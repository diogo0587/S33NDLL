using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class NotSendServiceEventsAgainMap : ClassMap<NotSendServiceEventsAgain>
    {
        public NotSendServiceEventsAgainMap()
        {
            Table("StarW_NotSendServiceEventsAgain");
            LazyLoad();
            Id(x => x.Id).Column("NtSerEA_Id").GeneratedBy.Identity();
            Map(x => x.Enable).Column("NtSerEA_Enable");
            Map(x => x.ProcessedDate).Column("NtSerEA_DateTimeProcessed");
            References(x => x.OrderService).Column("OrdS_Id").Cascade.None();
            HasMany(x => x.NotSendServiceEventsAgainDetails).KeyColumn("NtSerEA_Id").Inverse();
        }
    }
}
