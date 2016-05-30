using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ScanAuditingDetailTrackingMap : ClassMap<ScanAuditingDetailTracking>
    {
        public ScanAuditingDetailTrackingMap()
        {
            Table("StarW_ScanAndAuditingDetailTracking");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("ScAdtDT_Id");
            Map(x => x.Description).Column("ScAdtDT_Description");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.ScanAuditingDetail).Column("ScAdtD_Id");
            References(x => x.Alternative).Column("Alt_Id");
            References(x => x.Images).Column("Imag_Id");
            References(x => x.Account).Column("Acct_Id");            
        }
    }
}
