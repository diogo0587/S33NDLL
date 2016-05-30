using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ApplicationFlowSetupMap : ClassMap<ApplicationFlowSetup>
    {
        public ApplicationFlowSetupMap()
        {
            Table("StarW_ApplicationFlowSetup");
            LazyLoad();
            Id(x => x.Id).Column("AppFS_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("AppFS_Name");
            Map(x => x.Description).Column("AppFS_Description");
            Map(x => x.Sequence).Column("AppFS_Seq");
            Map(x => x.Enable).Column("AppFS_Enable");
            References(x => x.Operation).Column("Oper_Id");
            References(x => x.Account).Column("Acct_Id");
            References(x => x.ServiceEvent).Column("SerE_Id");
            HasMany(x => x.ApplicationFlowSetupDetails).KeyColumn("AppFS_Id").Inverse();
            HasMany(x => x.ApplicationFlowEntryPoints).KeyColumn("AppFS_Id").Inverse();
        }
    }
}
