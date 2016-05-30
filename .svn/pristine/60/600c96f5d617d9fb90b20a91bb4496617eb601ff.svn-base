using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class MobileDeviceControlVersionMap : ClassMap<MobileDeviceControlVersion>
    {
        public MobileDeviceControlVersionMap()
        {
            Table("StarW_MobileDeviceControlVersion");
            LazyLoad();
            Id(x => x.Id).Column("MbDCV_Id").GeneratedBy.Identity();
            Map(x => x.Enable).Column("MbDCV_Enable");
            Map(x => x.UpdatedVersion).Column("MbDCV_UpdatedVersion");
            Map(x => x.DownloadVersion).Column("MbDCV_DownloadVersion");
            References(x => x.MobileDevice).Column("MobD_Id");
            References(x => x.MobileDeviceVersion).Column("MbV_Id");
        }
    }
}
