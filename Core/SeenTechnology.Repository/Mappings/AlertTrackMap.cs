using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertTrackMap : ClassMap<AlertTrack>
    {
        public AlertTrackMap()
        {
            Table("StarW_AlertTrack");
            LazyLoad();
            Id(x => x.Id).Column("AltTrk_Id").GeneratedBy.Identity();
            Map(x => x.Enable).Column("AltTrk_Enable");
            Map(x => x.Message).Column("AltTrk_Message");
            Map(x => x.SourceValue).Column("AltTrk_Source");
            Map(x => x.ContactName).Column("AltTrk_ContactName");
            Map(x => x.DateTimeScheduling).Column("AltTrk_DatetimeScheduling");
            Map(x => x.DateTimeSend).Column("AltTrk_DatetimeSend");
            Map(x => x.Ticket).Column("AltTrk_Ticket");
            References(x => x.TypeSendingAlert).Column("TypSd_Id");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.ApplicationFlow).Column("AppF_Id");
        }
    }
}
