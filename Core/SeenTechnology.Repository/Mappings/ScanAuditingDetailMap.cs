using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ScanAuditingDetailMap : ClassMap<ScanAuditingDetail>
    {
        public ScanAuditingDetailMap()
        {
            Table("StarW_ScanAndAuditingDetail");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("ScAdtD_Id");
            Map(x => x.LastUpdate).Column("ScAdtD_LastUpdate");
            Map(x => x.Description).Column("ScAdtD_Description");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.ScanAndAudinting).Column("ScAdt_Id");
            References(x => x.Alternative).Column("Alt_Id");
            References(x => x.Images).Column("Imag_Id");
            References(x => x.Account).Column("Acct_Id");
            HasMany(x => x.ScanAuditingDetailTrackings).KeyColumn("ScAdtD_Id").Inverse();      
        }
    }
}
