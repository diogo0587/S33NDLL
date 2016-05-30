using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DeviceAllocatedMap : ClassMap<DeviceAllocated>
    {
        public DeviceAllocatedMap()
        {
            Table("StarW_DeviceAllocated");
            LazyLoad();
            Id(x => x.Id).Column("DevA_Id").GeneratedBy.Identity();
            References(x => x.Mobile).Column("MobD_Id");
            References(x => x.Technician).Column("Tech_Id");
        }
    }
}
