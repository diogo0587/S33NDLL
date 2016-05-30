using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Account : Entity<long>
    {
        [StringLength(100)]
        public virtual string Name { get; set; }
        [StringLength(50)]
        public virtual string User { get; set; }
        [StringLength(40)]
        public virtual string Password { get; set; }
        public virtual bool? Enable { get; set; }
        [StringLength(10)]
        public virtual string Culture { get; set; }

        #region HasMany
        public virtual IEnumerable<AccountSession> AccountSession { get; set; }
        public virtual IEnumerable<AccountStartPointOperation> AccountStartPointOperations { get; set; }
        public virtual IEnumerable<ApplicationFlowSetup> ApplicationFlowSetups { get; set; }
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
        public virtual IEnumerable<GroupAddressDetail> GroupAddressDetails { get; set; }
        public virtual IEnumerable<Images> Images { get; set; }
        public virtual IEnumerable<ImportOrderService> ImportOrderServices { get; set; }
        public virtual IEnumerable<ImportOrderServiceFile> ImportOrderServiceFiles { get; set; }
        public virtual IEnumerable<OrderServiceExportCte> OrderServiceExportCtes { get; set; }
        public virtual IEnumerable<OrderServiceTracking> OrderServiceTrackings { get; set; }
        public virtual IEnumerable<ParameterDashboardIndicator> ParameterDashboardIndicators { get; set; }
        public virtual IEnumerable<ScanAuditingDetailTracking> ScanAuditingDetailTrackings { get; set; }
        public virtual IEnumerable<SupportDetail> SupportDetails { get; set; }
        public virtual IEnumerable<Technician> Technicians { get; set; }
        #endregion
    }
}
