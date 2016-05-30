using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class SupportDetailMap : ClassMap<SupportDetail>
    {
        public SupportDetailMap()
        {
            Table("StarW_SupportDetail");
            LazyLoad();
            Id(x => x.Id).Column("SuptD_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("SuptD_Description");
            References(x => x.Account).Column("Acct_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.Support).Column("Supt_Id");
        }
    }
}
