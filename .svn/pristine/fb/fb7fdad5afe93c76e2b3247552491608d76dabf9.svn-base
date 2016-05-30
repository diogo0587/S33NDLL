using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class MobileDeviceMap : ClassMap<MobileDevice>
    {
        public MobileDeviceMap()
        {
            Table("StarW_MobileDevice");
            LazyLoad();
            Id(x => x.Id).Column("MobD_Id").GeneratedBy.Identity();
            Map(x => x.Imei).Column("MobD_Imei");
            Map(x => x.Manufacturer).Column("MobD_Manufacturer");
            Map(x => x.Model).Column("MobD_Model");
            Map(x => x.Enable).Column("MobD_Enable");
            Map(x => x.Lost).Column("MobD_Lost");
            References(x => x.StartPoint).Column("StrP_Id");
            HasMany(x => x.BiorecycleTemplates).KeyColumn("MobD_Id").Inverse();
            HasMany(x => x.DeviceAllocateds).KeyColumn("MobD_Id").Inverse();
            HasMany(x => x.GpsPositions).KeyColumn("MobD_Id").Inverse();
            HasMany(x => x.MobileDeviceControlVersions).KeyColumn("MobD_Id").Inverse();
            HasMany(x => x.Routes).KeyColumn("MobD_Id").Inverse();
            HasMany(x => x.SocketTrackings).KeyColumn("MobD_Id").Inverse();
        }
    }
}
