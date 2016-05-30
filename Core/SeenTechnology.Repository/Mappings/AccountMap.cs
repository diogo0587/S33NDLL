using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Table("StarW_Account");
            LazyLoad();
            Id(x => x.Id).Column("Acct_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("Acct_Name");
            Map(x => x.User).Column("Acct_User");
            Map(x => x.Password).Column("Acct_Password");
            Map(x => x.Enable).Column("Acct_Enable").Nullable();
            Map(x => x.Culture).Column("Acct_Culture");
            HasMany(x => x.AccountSession).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.AccountStartPointOperations).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.ApplicationFlowSetups).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.DashboardEvents).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.GroupAddressDetails).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.Images).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.ImportOrderServices).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.ImportOrderServiceFiles).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.OrderServiceExportCtes).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.OrderServiceTrackings).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.ParameterDashboardIndicators).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.ScanAuditingDetailTrackings).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.SupportDetails).KeyColumn("Acct_Id").Inverse();
            HasMany(x => x.Technicians).KeyColumn("Acct_Id").Inverse();
        }
    }
}
