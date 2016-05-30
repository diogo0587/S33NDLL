using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class GroupAddressDetailMap : ClassMap<GroupAddressDetail>
    {
        public GroupAddressDetailMap()
        {
            Table("StarW_GroupAddressDetail");
            LazyLoad();
            Id(x => x.Id).Column("GrpAddrD_Id").GeneratedBy.Identity();
            References(x => x.Account).Column("Acct_Id");
            References(x => x.Address).Column("Addr_Id");
            References(x => x.GroupAddress).Column("GrpAddr_Id");
        }
    }
}
