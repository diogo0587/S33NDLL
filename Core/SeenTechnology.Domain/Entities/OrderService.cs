using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class OrderService : Entity<long>
    {

        public virtual DateTime? DateTimeScheduling { get; set; }
        [StringLength(50)]
        public virtual string Protocol { get; set; }
        [StringLength(50)]
        public virtual string Reference { get; set; }
        [StringLength(100)]
        public virtual string Auxiliary1 { get; set; }
        [StringLength(100)]
        public virtual string Auxiliary2 { get; set; }
        [StringLength(100)]
        public virtual string Auxiliary3 { get; set; }
        [StringLength(100)]
        public virtual string Auxiliary4 { get; set; }
        [StringLength(100)]
        public virtual string Auxiliary5 { get; set; }
        [StringLength(200)]
        public virtual string WorkDay { get; set; }
        [StringLength(300)]
        public virtual string WoD { get; set; }
        [StringLength(50)]
        public virtual string ExternalId { get; set; }
        [StringLength(50)]
        public virtual string CustomerReference { get; set; }
        [StringLength(80)]
        public virtual string CorporateName { get; set; }
        [StringLength(40)]
        public virtual string PhoneNumber1 { get; set; }
        [StringLength(40)]
        public virtual string PhoneNumber2 { get; set; }
        [StringLength(40)]
        public virtual string Email { get; set; }

        public virtual RequestTracking RequestTraking { get; set; }
        public virtual Address Address { get; set; }
        public virtual OrderServiceType OrderServiceType { get; set; }
        public virtual StartPointOperation StartPointOperation { get; set; }
        public virtual GroupAddress Groupaddress { get; set; }

        #region Hasmany
        public virtual IEnumerable<ConsultProspectAccount> ConsultProspectAccounts { get; set; }
        public virtual IEnumerable<AlertTrack> AlertTracks { get; set; }
        public virtual IEnumerable<ClusteredWorkflow> ClusteredWorkflows { get; set; }
        public virtual IEnumerable<ClusteredWorkflowDetail> ClusteredWorkflowDetails { get; set; }
        public virtual IEnumerable<CustomAlternative> CustomAlternatives { get; set; }
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
        public virtual IEnumerable<Images> Images { get; set; }
        public virtual IEnumerable<ImportOrderService> ImportOrderServices { get; set; }
        public virtual IEnumerable<NotSendServiceEventsAgain> NotSendServiceEventsAgains { get; set; }
        public virtual IEnumerable<OrderServiceAttendance> OrderServiceAttendances { get; set; }
        public virtual IEnumerable<OrderServiceCustomer> OrderServiceCustomers { get; set; }
        public virtual IEnumerable<OrderServiceDetail> OrderServiceDetails { get; set; }
        public virtual IEnumerable<OrderServiceExportCteDetail> OrderServiceExportCteDetails { get; set; }
        public virtual IEnumerable<OrderServiceLayout> OrderServiceLayouts { get; set; }
        public virtual IEnumerable<OrderServiceStatus> OrderServiceStatuses { get; set; }
        public virtual IEnumerable<OrderServiceTracking> OrderServiceTrackings { get; set; }
        public virtual IEnumerable<OrderServiceWorkFlowAgain> OrderServiceWorkFlowAgains { get; set; }
        public virtual IEnumerable<OrderServiceWorkflowToken> OrderServiceWorkflowTokens { get; set; }
        public virtual IEnumerable<RouteDetail> RouteDetails { get; set; }
        public virtual IEnumerable<ScanAuditing> ScanAuditings { get; set; }
        public virtual IEnumerable<Support> Supports { get; set; }
        #endregion



        public OrderService() { }
    }
}
