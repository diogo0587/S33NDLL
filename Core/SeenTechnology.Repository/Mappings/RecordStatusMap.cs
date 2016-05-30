using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RecordStatusMap : ClassMap<RecordStatus>
    {
        public RecordStatusMap()
        {
            Table("StarW_RecordStatus");
            LazyLoad();
            Id(x => x.Id).Column("RecSt_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("RecSt_Description");
            Map(x => x.Name).Column("RecSt_Name");
            Map(x => x.Group).Column("RecSt_Group");
            Map(x => x.DescriptionDetail).Column("RecSt_DescriptionDetail");
            Map(x => x.DescriptionView).Column("RecSt_DescriptionView");
            HasMany(x => x.ConsultProspectAccounts).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.Pacs).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.Pactemplates).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.Alerttracks).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.ApplicationFlowSetupDetails).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.DashboardEvents).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.ImportOrderServices).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.ImportOrderServiceFiles).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.NotifyOrderServices).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.OrderServiceStatuses).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.OrderServiceWorkFlowAgains).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.RequestTrackings).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.RequestTrackingDetails).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.Routes).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.RouteDetails).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.ScanAuditings).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.ScanAuditingDetails).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.ScanAuditingDetailTrackings).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.SendWorkflowToCustomers).KeyColumn("RecSt_Id").Inverse();
            HasMany(x => x.SupportDetails).KeyColumn("RecSt_Id").Inverse();
        }
    }
}
