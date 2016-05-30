using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AccountStartPointOperationMap : ClassMap<AccountStartPointOperation>
    {
        public AccountStartPointOperationMap()
        {
            Table("StarW_AcctXStartXOper");
            LazyLoad();
            Id(x => x.Id).Column("ActStOp_Id").GeneratedBy.Identity();
            References(x => x.Account).Column("Acct_Id");
            References(x => x.StartPointOperation).Column("StpxOp_Id");
        }
    }
}
