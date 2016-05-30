using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class GroupAddressMap : ClassMap<GroupAddress>
    {
        public GroupAddressMap()
        {
            Table("StarW_GroupAddress");
            LazyLoad();
            Id(x => x.Id).Column("GrpAddr_Id").GeneratedBy.Identity();
            HasMany(x => x.GroupAddressDetails).KeyColumn("GrpAddr_Id").Inverse();
            HasMany(x => x.Orderservices).KeyColumn("GrpAddr_Id").Inverse();
        }
    }
}
