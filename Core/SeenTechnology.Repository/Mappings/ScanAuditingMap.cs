using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ScanAuditingMap : ClassMap<ScanAuditing>
    {
        public ScanAuditingMap()
        {
            Table("StarW_ScanAndAuditing");
            LazyLoad();
            Id(x => x.Id).Column("ScAdt_Id").GeneratedBy.Identity();
            Map(x => x.TrackingNumber).Column("ScAdt_TrackingNumber");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.OrderService).Column("OrdS_Id");
            HasMany(x => x.ScanAuditingDetails).KeyColumn("ScAdt_Id").Inverse();
        }
    }
}
