using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ImagesMap : ClassMap<Images>
    {
        public ImagesMap()
        {
            Table("StarW_Images");
            LazyLoad();
            Id(x => x.Id).Column("Imag_Id").GeneratedBy.Identity();
            Map(x => x.FileName).Column("Imag_FileName");
            Map(x => x.Latitude).Column("Imag_Lat");
            Map(x => x.Longitude).Column("Imag_Lng");
            Map(x => x.Timestamp).Column("Imag_Timestamp");
            Map(x => x.VirtualFileName).Column("Imag_VirtualFileName");
            Map(x => x.Spin).Column("Imag_Spin");
            References(x => x.OrderService).Column("OrdS_ID");
            References(x => x.Technician).Column("Tech_Id");
            References(x => x.ImageType).Column("ImagT_Id");
            References(x => x.Account).Column("Acct_Id");
            HasMany(x => x.Dashboardevents).KeyColumn("Imag_Id").Inverse();
            HasMany(x => x.ScanAuditingDetails).KeyColumn("Imag_Id").Inverse();
            HasMany(x => x.ScanAuditingDetailTrackings).KeyColumn("Imag_Id").Inverse();
        }
    }
}
