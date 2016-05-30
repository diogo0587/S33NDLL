using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AccountSessionMap : ClassMap<AccountSession>
    {
        public AccountSessionMap()
        {
            Table("StarW_AccountSession");
            LazyLoad();
            Id(x => x.Id).Column("AcctS_Id").GeneratedBy.Identity();            
            Map(x => x.SessionGuid).Column("AcctS_SessionGuid");
            Map(x => x.DateTimeExpiration).Column("AcctS_SessionExpirationDate");
            References(x => x.Account).Column("Acct_Id");
        }
    }
}
