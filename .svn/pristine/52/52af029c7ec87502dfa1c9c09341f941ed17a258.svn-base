using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class RecordStatus : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        [StringLength(100)]
        public virtual string Group { get; set; }
        [StringLength(255)]
        public virtual string Name { get; set; }
        [StringLength(255)]
        public virtual string DescriptionDetail { get; set; }
        [StringLength(100)]
        public virtual string DescriptionView { get; set; }

        #region HasMany
        public virtual IEnumerable<ConsultProspectAccount> ConsultProspectAccounts { get; set; }
        public virtual IEnumerable<PAC> Pacs { get; set; }
        public virtual IEnumerable<PACTemplate> Pactemplates { get; set; }
        public virtual IEnumerable<AlertTrack> Alerttracks { get; set; }
        public virtual IEnumerable<ApplicationFlowSetupDetail> ApplicationFlowSetupDetails { get; set; }
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
        public virtual IEnumerable<ImportOrderService> ImportOrderServices { get; set; }
        public virtual IEnumerable<ImportOrderServiceFile> ImportOrderServiceFiles { get; set; }
        public virtual IEnumerable<NotifyOrderService> NotifyOrderServices { get; set; }
        public virtual IEnumerable<OrderServiceStatus> OrderServiceStatuses { get; set; }
        public virtual IEnumerable<OrderServiceWorkFlowAgain> OrderServiceWorkFlowAgains { get; set; }
        public virtual IEnumerable<RequestTracking> RequestTrackings { get; set; }
        public virtual IEnumerable<RequestTrackingDetail> RequestTrackingDetails { get; set; }
        public virtual IEnumerable<Route> Routes { get; set; }
        public virtual IEnumerable<RouteDetail> RouteDetails { get; set; }
        public virtual IEnumerable<ScanAuditing> ScanAuditings { get; set; }
        public virtual IEnumerable<ScanAuditingDetail> ScanAuditingDetails { get; set; }
        public virtual IEnumerable<ScanAuditingDetailTracking> ScanAuditingDetailTrackings { get; set; }
        public virtual IEnumerable<SendWorkflowToCustomer> SendWorkflowToCustomers { get; set; }
        public virtual IEnumerable<SupportDetail> SupportDetails { get; set; }
        #endregion

        public RecordStatus() { }
    }
}
