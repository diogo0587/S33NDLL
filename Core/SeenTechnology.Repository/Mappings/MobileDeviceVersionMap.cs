using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class MobileDeviceVersionMap : ClassMap<MobileDeviceVersion>
    {
        public MobileDeviceVersionMap()
        {
            Table("StarW_MobileDeviceVersion");
            LazyLoad();
            Id(x => x.Id).Column("MbV_Id").GeneratedBy.Identity();
            Map(x => x.FileName).Column("MbV_FileName");
            Map(x => x.DeviceVersion).Column("MbV_Version");
            Map(x => x.Release).Column("MbV_ReleaseDescription");
            Map(x => x.CurrentVersion).Column("MbV_CurrentVersion");
            Map(x => x.Enable).Column("MbV_Enable");
            HasMany(x => x.MobileDeviceControlVersions).KeyColumn("MbV_Id").Inverse();
        }
    }
}
